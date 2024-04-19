using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using SharpAvi.Codecs;
using SharpAvi.Output;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ButtonEmulator
{
    public class RecorderParams
    {
        private static int DPI = int.Parse((string)Registry.GetValue(
            @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\ThemeManager",
            "LastLoadedDPI", "96"));

        private static double scale = (double)DPI / 96;

        private readonly string fileName;
        private readonly int framesPerSecond;

        public RecorderParams(string filename, int frameRate, int quality)
        {
            fileName = filename;
            framesPerSecond = frameRate;
            Quality = quality;
        }

        public int Quality { get; }
        public int Height { get; } = (int)(Screen.PrimaryScreen.Bounds.Height * scale);
        public int Width { get; } = (int)(Screen.PrimaryScreen.Bounds.Width * scale);

        public AviWriter CreateAviWriter()
        {
            return new AviWriter(fileName)
            {
                FramesPerSecond = framesPerSecond,
                EmitIndex1 = true,
            };
        }
    }

    public class Recorder : IDisposable
    {
        private AviWriter writer;
        private IAviVideoStream videoStream;
        private Thread screenThread;

        private readonly ManualResetEvent stopThread = new(false);

        public Recorder() : this(null)
        {
        }

        public Recorder(RecorderParams @params)
        {
            Params = @params;
        }

        public RecorderParams Params { get; set; }

        public void StartRecord()
        {
            screenThread = new Thread(RecordScreen) { IsBackground = true };
            writer = Params.CreateAviWriter();
            videoStream = writer.AddMJpegWpfVideoStream(Params.Width, Params.Height, Params.Quality); // вот это ломает
            stopThread.Reset();
            screenThread.Start();
        }

        public void Dispose()
        {
            stopThread.Set();
            screenThread.Join();
            writer.Close();
        }

        private void RecordScreen()
        {
            var frameInterval = TimeSpan.FromSeconds(1 / (double)writer.FramesPerSecond);
            var buffer = new byte[Params.Width * Params.Height * 4];
            Task videoWriteTask = null;
            var timeTillNextFrame = TimeSpan.Zero;

            while (!stopThread.WaitOne(timeTillNextFrame))
            {
                var timestamp = DateTime.Now + frameInterval;
                Screenshot(buffer);
                videoWriteTask = videoStream.WriteFrameAsync(true, buffer, 0, buffer.Length);
                videoWriteTask?.Wait();
                timeTillNextFrame = timestamp - DateTime.Now;
                if (timeTillNextFrame <= TimeSpan.Zero)
                {
                    timeTillNextFrame = TimeSpan.Zero;
                }
            }
            videoWriteTask?.Wait();
        }

        private void Screenshot(byte[] buffer)
        {
            using var bmp = new Bitmap(Params.Width, Params.Height);
            using var g = Graphics.FromImage(bmp);
            g.CopyFromScreen(Point.Empty, Point.Empty, new Size(Params.Width, Params.Height), CopyPixelOperation.SourceCopy);
            g.Flush();
            var bits = bmp.LockBits(new Rectangle(0, 0, Params.Width, Params.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppRgb);
            Marshal.Copy(bits.Scan0, buffer, 0, buffer.Length);
            bmp.UnlockBits(bits);
        }
    }
}
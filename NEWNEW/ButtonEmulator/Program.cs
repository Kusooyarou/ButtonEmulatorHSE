using System;
using System.Windows.Forms;

namespace ButtonEmulator
{
    internal static class Program
    {
        public static Form1 Form1connect;

        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Form1connect = new Form1();
            Application.Run(Form1connect);
        }
    }
}

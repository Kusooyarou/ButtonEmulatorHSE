using System.Configuration;
using System.Diagnostics;

namespace ButtonEmulator
{
    public class NoTaskManager
    {
        public NoTaskManager() : this("ButtonEmulator")
        {
        }

        public NoTaskManager(string name)
        {
            Name = name;

            DisableLock = ConfigurationManager.AppSettings["disablelock"] == "true" || Debugger.IsAttached;
        }

        public bool DisableLock { get; }

        private string Name { get; }

        public void CheckProcess()
        {
            if (DisableLock)
            {
                return;
            }

            int processCount = 0;
            foreach(Process process in Process.GetProcesses())
            {
                if (process.ProcessName == Name)
                {
                    processCount++;
                }
            }
            if (processCount < 2)
            {
                Process.Start(Name);  
            }        
        }       
    }
}

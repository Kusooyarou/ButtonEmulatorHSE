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
        }

        private string Name { get; }

        public void CheckProcess()
        {
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
                if (!Debugger.IsAttached)
                {
                    //Process.Start(Name);  
                }
            }        
        }       
    }
}

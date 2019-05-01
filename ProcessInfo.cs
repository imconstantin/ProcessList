using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProcessList
{
    public class ProcessInfo
    {
        public string name;

        public int procID;

        public string status;

        public double memory;

        public ProcessInfo(string _name, int _procID, string _status, double _memory)
        {
            name = _name;
            procID = _procID;
            status = _status;
            memory = _memory;
        }

        // Returns a list of ProcessInfo type with all the system processes
        public static List<ProcessInfo> GetProcessesInfo()
        {
            List<ProcessInfo> procList = new List<ProcessInfo>();
            Process[] processes = Process.GetProcesses();

            foreach (var proc in processes)
            {
                double memory = Math.Round(((proc.WorkingSet64 / 1024f) / 1024f), 2);
                string status = proc.Responding ? "Running" : "Not responding";
                procList.Add(new ProcessInfo(proc.ProcessName, proc.Id, status, memory));
            }

            return procList;
        }
    }
}

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
        public string Name;

        public string ProcID;

        public string Status;

        public ProcessInfo(string _name, string _procID, string _status)
        {
            Name = _name;
            ProcID = _procID;
            Status = _status;
        }

        public static List<ProcessInfo> GetProcessesInfo()
        {
            List<ProcessInfo> procList = new List<ProcessInfo>();
            Process[] processes = Process.GetProcesses();

            foreach (var proc in processes)
            {
                procList.Add(new ProcessInfo(proc.ProcessName, proc.Id.ToString(), "Status"));
            }

            return procList;
        }
    }
}

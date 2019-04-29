using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProcessList
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void checkBoxStart_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStart.Checked == true)
            {
                Task task = new Task(AddProcInfoToList);
                task.Start();            
            }
        }

        public void AddProcInfoToList()
        {
            while (checkBoxStart.Checked == true)
            {
                List<ProcessInfo> processes = ProcessInfo.GetProcessesInfo();

                if (listViewRunnProc.Items.Count == 0)
                {
                    foreach (var proc in processes)
                    {
                        ListViewItem listViewItem = new ListViewItem(proc.Name);
                        listViewItem.SubItems.Add(proc.ProcID);
                        listViewItem.SubItems.Add("Status");
                        listViewRunnProc.Invoke(new Action(() => listViewRunnProc.Items.Add(listViewItem)));
                    }
                }
                else
                {
                    foreach (ListViewItem viewItem in listViewRunnProc.Items)
                    {

                    }
                }
               
                Thread.Sleep(2000);
            }
        }
    }
}

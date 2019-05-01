﻿using System;
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

        private void checkBoxStart_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStart.Checked == true)
            {
                // Start second thread
                Thread task = new Thread(AddProcInfoToList);
                task.Start();            
            }
            else
            {
                listViewRunnProc.Items.Clear();
            }
        }

        #region Loop at 1 sec and call the update method
        public void AddProcInfoToList()
        {
            while (checkBoxStart.Checked == true)
            {
                InvokeUI(UpdateListViewProcc);
                Thread.Sleep(1000);
            }
        }

        private void InvokeUI(Action method)
        {
            this.BeginInvoke(new MethodInvoker(method));
        }
        #endregion

        // Update the form with processes information
        public void UpdateListViewProcc()
        {
            List<ProcessInfo> processes = ProcessInfo.GetProcessesInfo();

            
            if (listViewRunnProc.Items.Count == 0)
            {
                foreach (var proc in processes)
                {
                    ListViewItem listViewItem = new ListViewItem(proc.name);
                    listViewItem.SubItems.Add(proc.procID.ToString());
                    listViewItem.SubItems.Add(proc.status.ToString());
                    listViewItem.SubItems.Add(proc.memory.ToString());
                    listViewRunnProc.Items.Add(listViewItem);
                }
            }
            else
            {
                foreach (ListViewItem viewItem in listViewRunnProc.Items)
                {
                    ProcessInfo matchProcess = processes.Find(x => x.procID.ToString() == viewItem.SubItems[1].Text);

                    if (matchProcess != null)
                    {
                        if (matchProcess.status != viewItem.SubItems[2].Text)
                            viewItem.SubItems[2].Text = matchProcess.status;

                        if (matchProcess.memory.ToString() != viewItem.SubItems[3].Text)
                            viewItem.SubItems[3].Text = matchProcess.memory.ToString();
                    }
                    else
                    {
                        // the process is closed, remove it from the form
                        listViewRunnProc.Items.Remove(viewItem);
                    }      
                }
                
                // new processes to be added on form
                if (listViewRunnProc.Items.Count < processes.Count)
                {
                    List<int> listViewItems = listViewRunnProc.Items.Cast<ListViewItem>().Select(x => int.Parse(x.SubItems[1].Text)).ToList();
                    var newProcesses = processes.Where(p => !listViewItems.Any(p2 => p2 == p.procID));

                    foreach (ProcessInfo item in newProcesses)
                    {
                        ListViewItem listViewItem = new ListViewItem(item.name);
                        listViewItem.SubItems.Add(item.procID.ToString());
                        listViewItem.SubItems.Add(item.status.ToString());
                        listViewItem.SubItems.Add(item.memory.ToString());
                        listViewRunnProc.Items.Add(listViewItem);
                    }
                }
            }
        }
    }
}
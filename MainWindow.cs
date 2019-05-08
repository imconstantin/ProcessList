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
using System.Diagnostics;
using System.IO;

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
                task.IsBackground = true;
                task.Start();

                // Enable UI
                buttonKillProcess.Enabled = true;
                buttonExport.Enabled = true;
                label1.Enabled = true;
                label2.Enabled = true;
                comboBoxExport.Enabled = true;
                comboBoxKillProcess.Enabled = true;
                textBoxKillProcess.Enabled = true;
            }
            else
            {
                listViewRunnProc.Items.Clear();
                labelTotal.Hide();
                labelTotalNr.Hide();

                // Disable UI
                buttonKillProcess.Enabled = false;
                buttonExport.Enabled = false;
                label1.Enabled = false;
                label2.Enabled = false;
                comboBoxExport.Enabled = false;
                comboBoxKillProcess.Enabled = false;
                textBoxKillProcess.Enabled = false;
            }
        }

        // Loop at 1 sec and call the update method
        public void AddProcInfoToList()
        {
            while (checkBoxStart.Checked == true)
            {
                this.Invoke(new MethodInvoker(UpdateListViewProcc));
                Thread.Sleep(1000);
            }
        }

        // Update the form with processes information
        public void UpdateListViewProcc()
        {
            List<ProcessInfo> processes = ProcessInfo.GetProcessesList(Process.GetProcesses());
  
            if (listViewRunnProc.Items.Count == 0)
            {
                foreach (var proc in processes)
                {
                    ListViewItem listViewItem = new ListViewItem(proc.Name);
                    listViewItem.SubItems.Add(proc.ProcID.ToString());
                    listViewItem.SubItems.Add(proc.Status.ToString());
                    listViewItem.SubItems.Add(proc.Memory.ToString());
                    listViewRunnProc.Items.Add(listViewItem);

                    labelTotalNr.Text = listViewRunnProc.Items.Count.ToString();
                    labelTotal.Show();
                    labelTotalNr.Show();
                }
            }
            else
            {
                foreach (ListViewItem viewItem in listViewRunnProc.Items)
                {
                    ProcessInfo matchProcess = processes.Find(x => x.ProcID.ToString() == viewItem.SubItems[1].Text);

                    if (matchProcess != null)
                    {
                        if (matchProcess.Status != viewItem.SubItems[2].Text)
                            viewItem.SubItems[2].Text = matchProcess.Status;

                        if (matchProcess.Memory.ToString() != viewItem.SubItems[3].Text)
                            viewItem.SubItems[3].Text = matchProcess.Memory.ToString();
                    }
                    else
                    {
                        // the process is closed, remove it from the form
                        listViewRunnProc.Items.Remove(viewItem);

                        labelTotalNr.Text = listViewRunnProc.Items.Count.ToString();
                    }      
                }
                
                // new processes to be added on form
                if (listViewRunnProc.Items.Count < processes.Count)
                {
                    List<int> listViewItems = listViewRunnProc.Items.Cast<ListViewItem>().Select(x => int.Parse(x.SubItems[1].Text)).ToList();
                    var newProcesses = processes.Where(p => !listViewItems.Any(p2 => p2 == p.ProcID));

                    foreach (ProcessInfo item in newProcesses)
                    {
                        ListViewItem listViewItem = new ListViewItem(item.Name);
                        listViewItem.SubItems.Add(item.ProcID.ToString());
                        listViewItem.SubItems.Add(item.Status.ToString());
                        listViewItem.SubItems.Add(item.Memory.ToString());
                        listViewRunnProc.Items.Add(listViewItem);

                        labelTotalNr.Text = listViewRunnProc.Items.Count.ToString();
                    }
                }
            }
        }

        private void buttonKillProcess_Click(object sender, EventArgs e)
        {
            if (comboBoxKillProcess.SelectedItem != null)
            {
                if (comboBoxKillProcess.SelectedItem.ToString() == "Name")
                {
                    try
                    {
                        Process[] processes = Process.GetProcessesByName(textBoxKillProcess.Text);

                        if (processes.Count() > 0)
                        {
                            foreach (Process proc in processes)
                            {
                                proc.Kill();
                            }

                            MessageBox.Show("Successfully killed " + processes.Count().ToString() + " processes", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Unable to find any processes by name: " + textBoxKillProcess.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (comboBoxKillProcess.SelectedItem.ToString() == "PID")
                {
                    try
                    {
                        Process[] processes = Process.GetProcesses();

                        for(int i=0; i<processes.Length; i++)
                        {
                            if (processes[i].Id == int.Parse(textBoxKillProcess.Text))
                            {
                                processes[i].Kill();
                                break;
                            }

                            if (i == processes.Length - 1)
                            {
                                MessageBox.Show("Unable to find any processes by ID: " + textBoxKillProcess.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }                 
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select on which criteria to kill the process!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (comboBoxExport.SelectedItem != null)
            {
                if (comboBoxExport.SelectedItem.ToString() == "JSON")
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "JSON File|*.json";
                    saveFileDialog.Title = "Save as JSON File";

                    DialogResult result = saveFileDialog.ShowDialog();
                        
                    if (result == DialogResult.OK)
                    {
                        if (ExportList.ExportToJSON(ProcessInfo.GetProcessesList(Process.GetProcesses()), Path.GetFullPath(saveFileDialog.FileName)))
                        {
                            MessageBox.Show("List exported successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }           
                }

                if (comboBoxExport.SelectedItem.ToString() == "XML")
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "XML File|*.xml";
                    saveFileDialog.Title = "Save as XML File";

                    DialogResult result = saveFileDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        if (ExportList.ExportToXML(ProcessInfo.GetProcessesList(Process.GetProcesses()), Path.GetFullPath(saveFileDialog.FileName)))
                        {
                            MessageBox.Show("List exported successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                if (comboBoxExport.SelectedItem.ToString() == "CSV")
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "CSV File|*.csv";
                    saveFileDialog.Title = "Save as CSV File";

                    DialogResult result = saveFileDialog.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        if (ExportList.ExportToCSV(ProcessInfo.GetProcessesList(Process.GetProcesses()), Path.GetFullPath(saveFileDialog.FileName)))
                        {
                            MessageBox.Show("List exported successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                } 
            }
            else
            {
                MessageBox.Show("Please select a type of format to export!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

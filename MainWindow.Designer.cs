namespace ProcessList
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.listViewRunnProc = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMemory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonExport = new System.Windows.Forms.Button();
            this.checkBoxStart = new System.Windows.Forms.CheckBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalNr = new System.Windows.Forms.Label();
            this.comboBoxKillProcess = new System.Windows.Forms.ComboBox();
            this.textBoxKillProcess = new System.Windows.Forms.TextBox();
            this.buttonKillProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxExport = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listViewRunnProc
            // 
            this.listViewRunnProc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnPID,
            this.columnStatus,
            this.columnMemory});
            this.listViewRunnProc.FullRowSelect = true;
            this.listViewRunnProc.Location = new System.Drawing.Point(12, 101);
            this.listViewRunnProc.Name = "listViewRunnProc";
            this.listViewRunnProc.Size = new System.Drawing.Size(371, 385);
            this.listViewRunnProc.TabIndex = 0;
            this.listViewRunnProc.UseCompatibleStateImageBehavior = false;
            this.listViewRunnProc.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 103;
            // 
            // columnPID
            // 
            this.columnPID.Text = "PID";
            this.columnPID.Width = 91;
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Status";
            this.columnStatus.Width = 88;
            // 
            // columnMemory
            // 
            this.columnMemory.Text = "Memory MB";
            this.columnMemory.Width = 83;
            // 
            // buttonExport
            // 
            this.buttonExport.Enabled = false;
            this.buttonExport.Location = new System.Drawing.Point(223, 12);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // checkBoxStart
            // 
            this.checkBoxStart.AutoSize = true;
            this.checkBoxStart.Location = new System.Drawing.Point(12, 78);
            this.checkBoxStart.Name = "checkBoxStart";
            this.checkBoxStart.Size = new System.Drawing.Size(93, 17);
            this.checkBoxStart.TabIndex = 4;
            this.checkBoxStart.Text = "List processes";
            this.checkBoxStart.UseVisualStyleBackColor = true;
            this.checkBoxStart.CheckedChanged += new System.EventHandler(this.checkBoxStart_CheckedChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(328, 79);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(34, 13);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total:";
            this.labelTotal.Visible = false;
            // 
            // labelTotalNr
            // 
            this.labelTotalNr.AutoSize = true;
            this.labelTotalNr.Location = new System.Drawing.Point(362, 79);
            this.labelTotalNr.Name = "labelTotalNr";
            this.labelTotalNr.Size = new System.Drawing.Size(13, 13);
            this.labelTotalNr.TabIndex = 6;
            this.labelTotalNr.Text = "0";
            this.labelTotalNr.Visible = false;
            // 
            // comboBoxKillProcess
            // 
            this.comboBoxKillProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKillProcess.Enabled = false;
            this.comboBoxKillProcess.FormattingEnabled = true;
            this.comboBoxKillProcess.Items.AddRange(new object[] {
            "Name",
            "PID"});
            this.comboBoxKillProcess.Location = new System.Drawing.Point(107, 13);
            this.comboBoxKillProcess.Name = "comboBoxKillProcess";
            this.comboBoxKillProcess.Size = new System.Drawing.Size(75, 21);
            this.comboBoxKillProcess.TabIndex = 8;
            // 
            // textBoxKillProcess
            // 
            this.textBoxKillProcess.Enabled = false;
            this.textBoxKillProcess.Location = new System.Drawing.Point(12, 40);
            this.textBoxKillProcess.Name = "textBoxKillProcess";
            this.textBoxKillProcess.Size = new System.Drawing.Size(170, 20);
            this.textBoxKillProcess.TabIndex = 9;
            // 
            // buttonKillProcess
            // 
            this.buttonKillProcess.Enabled = false;
            this.buttonKillProcess.Location = new System.Drawing.Point(11, 12);
            this.buttonKillProcess.Name = "buttonKillProcess";
            this.buttonKillProcess.Size = new System.Drawing.Size(74, 23);
            this.buttonKillProcess.TabIndex = 10;
            this.buttonKillProcess.Text = "Kill process";
            this.buttonKillProcess.UseVisualStyleBackColor = true;
            this.buttonKillProcess.Click += new System.EventHandler(this.buttonKillProcess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(87, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(301, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "to";
            // 
            // comboBoxExport
            // 
            this.comboBoxExport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExport.Enabled = false;
            this.comboBoxExport.FormattingEnabled = true;
            this.comboBoxExport.Items.AddRange(new object[] {
            "XML",
            "JSON",
            "CSV"});
            this.comboBoxExport.Location = new System.Drawing.Point(318, 13);
            this.comboBoxExport.Name = "comboBoxExport";
            this.comboBoxExport.Size = new System.Drawing.Size(65, 21);
            this.comboBoxExport.TabIndex = 13;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 498);
            this.Controls.Add(this.comboBoxExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKillProcess);
            this.Controls.Add(this.textBoxKillProcess);
            this.Controls.Add(this.comboBoxKillProcess);
            this.Controls.Add(this.labelTotalNr);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.checkBoxStart);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.listViewRunnProc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "ProessList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewRunnProc;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPID;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.CheckBox checkBoxStart;
        private System.Windows.Forms.ColumnHeader columnMemory;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalNr;
        private System.Windows.Forms.ComboBox comboBoxKillProcess;
        private System.Windows.Forms.TextBox textBoxKillProcess;
        private System.Windows.Forms.Button buttonKillProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxExport;
    }
}


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
            this.listViewRunnProc = new System.Windows.Forms.ListView();
            this.labelRunProc = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonKillProc = new System.Windows.Forms.Button();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewRunnProc
            // 
            this.listViewRunnProc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnPID,
            this.columnStatus});
            this.listViewRunnProc.Location = new System.Drawing.Point(13, 72);
            this.listViewRunnProc.Name = "listViewRunnProc";
            this.listViewRunnProc.Size = new System.Drawing.Size(453, 399);
            this.listViewRunnProc.TabIndex = 0;
            this.listViewRunnProc.UseCompatibleStateImageBehavior = false;
            this.listViewRunnProc.View = System.Windows.Forms.View.Details;
            // 
            // labelRunProc
            // 
            this.labelRunProc.AutoSize = true;
            this.labelRunProc.Location = new System.Drawing.Point(10, 54);
            this.labelRunProc.Name = "labelRunProc";
            this.labelRunProc.Size = new System.Drawing.Size(101, 13);
            this.labelRunProc.TabIndex = 1;
            this.labelRunProc.Text = "Running processes:";
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(13, 13);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 2;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // buttonKillProc
            // 
            this.buttonKillProc.Location = new System.Drawing.Point(105, 13);
            this.buttonKillProc.Name = "buttonKillProc";
            this.buttonKillProc.Size = new System.Drawing.Size(75, 23);
            this.buttonKillProc.TabIndex = 3;
            this.buttonKillProc.Text = "Kill process";
            this.buttonKillProc.UseVisualStyleBackColor = true;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            // 
            // columnPID
            // 
            this.columnPID.Text = "PID";
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Status";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 483);
            this.Controls.Add(this.buttonKillProc);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.labelRunProc);
            this.Controls.Add(this.listViewRunnProc);
            this.Name = "MainWindow";
            this.Text = "ProessList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewRunnProc;
        private System.Windows.Forms.Label labelRunProc;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonKillProc;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPID;
        private System.Windows.Forms.ColumnHeader columnStatus;
    }
}


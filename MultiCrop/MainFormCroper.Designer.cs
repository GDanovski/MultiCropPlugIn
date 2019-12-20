namespace MultiCrop
{
    partial class MainFormCroper
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProcessBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DirTB = new System.Windows.Forms.TextBox();
            this.ClassTB = new System.Windows.Forms.TextBox();
            this.SufficsTB = new System.Windows.Forms.TextBox();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkBox_Tracking = new System.Windows.Forms.CheckBox();
            this.checkBox_CopyRoi = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save to:";
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Location = new System.Drawing.Point(159, 186);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(75, 23);
            this.ProcessBtn.TabIndex = 1;
            this.ProcessBtn.Text = "Process";
            this.ProcessBtn.UseVisualStyleBackColor = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Suffix:";
            // 
            // DirTB
            // 
            this.DirTB.Location = new System.Drawing.Point(98, 20);
            this.DirTB.Name = "DirTB";
            this.DirTB.Size = new System.Drawing.Size(226, 20);
            this.DirTB.TabIndex = 4;
            // 
            // ClassTB
            // 
            this.ClassTB.Location = new System.Drawing.Point(98, 47);
            this.ClassTB.Name = "ClassTB";
            this.ClassTB.Size = new System.Drawing.Size(226, 20);
            this.ClassTB.TabIndex = 5;
            // 
            // SufficsTB
            // 
            this.SufficsTB.Location = new System.Drawing.Point(98, 74);
            this.SufficsTB.Name = "SufficsTB";
            this.SufficsTB.Size = new System.Drawing.Size(226, 20);
            this.SufficsTB.TabIndex = 6;
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(330, 19);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(52, 23);
            this.BrowseBtn.TabIndex = 7;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 163);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(365, 16);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // checkBox_Tracking
            // 
            this.checkBox_Tracking.AutoSize = true;
            this.checkBox_Tracking.Checked = true;
            this.checkBox_Tracking.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Tracking.Location = new System.Drawing.Point(145, 135);
            this.checkBox_Tracking.Name = "checkBox_Tracking";
            this.checkBox_Tracking.Size = new System.Drawing.Size(104, 17);
            this.checkBox_Tracking.TabIndex = 9;
            this.checkBox_Tracking.Text = "Enable Tracking";
            this.checkBox_Tracking.UseVisualStyleBackColor = true;
            // 
            // checkBox_CopyRoi
            // 
            this.checkBox_CopyRoi.AutoSize = true;
            this.checkBox_CopyRoi.Checked = true;
            this.checkBox_CopyRoi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_CopyRoi.Location = new System.Drawing.Point(145, 112);
            this.checkBox_CopyRoi.Name = "checkBox_CopyRoi";
            this.checkBox_CopyRoi.Size = new System.Drawing.Size(70, 17);
            this.checkBox_CopyRoi.TabIndex = 10;
            this.checkBox_CopyRoi.Text = "Crop ROI";
            this.checkBox_CopyRoi.UseVisualStyleBackColor = true;
            this.checkBox_CopyRoi.CheckedChanged += new System.EventHandler(this.checkBox_CopyRoi_CheckedChanged);
            // 
            // MainFormCroper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 237);
            this.Controls.Add(this.checkBox_CopyRoi);
            this.Controls.Add(this.checkBox_Tracking);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.SufficsTB);
            this.Controls.Add(this.ClassTB);
            this.Controls.Add(this.DirTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProcessBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainFormCroper";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiCrop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ProcessBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox DirTB;
        private System.Windows.Forms.TextBox ClassTB;
        private System.Windows.Forms.TextBox SufficsTB;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox checkBox_Tracking;
        private System.Windows.Forms.CheckBox checkBox_CopyRoi;
    }
}
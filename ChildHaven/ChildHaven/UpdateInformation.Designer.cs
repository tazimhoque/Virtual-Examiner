namespace ChildHaven
{
    partial class UpdateInformation
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
            this.labelTotalUpdate = new System.Windows.Forms.Label();
            this.buttonDownloadAll = new System.Windows.Forms.Button();
            this.buttonLimitedDownload = new System.Windows.Forms.Button();
            this.labelUpdateNumber = new System.Windows.Forms.Label();
            this.comboBoxUpdateNumber = new System.Windows.Forms.ComboBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelDownloadStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTotalUpdate
            // 
            this.labelTotalUpdate.AutoSize = true;
            this.labelTotalUpdate.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalUpdate.ForeColor = System.Drawing.Color.Blue;
            this.labelTotalUpdate.Location = new System.Drawing.Point(168, 49);
            this.labelTotalUpdate.Name = "labelTotalUpdate";
            this.labelTotalUpdate.Size = new System.Drawing.Size(371, 35);
            this.labelTotalUpdate.TabIndex = 0;
            this.labelTotalUpdate.Text = "Checking for Updates.....";
            // 
            // buttonDownloadAll
            // 
            this.buttonDownloadAll.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadAll.ForeColor = System.Drawing.Color.DeepPink;
            this.buttonDownloadAll.Location = new System.Drawing.Point(250, 283);
            this.buttonDownloadAll.Name = "buttonDownloadAll";
            this.buttonDownloadAll.Size = new System.Drawing.Size(175, 60);
            this.buttonDownloadAll.TabIndex = 1;
            this.buttonDownloadAll.Text = "Download All";
            this.buttonDownloadAll.UseVisualStyleBackColor = true;
            this.buttonDownloadAll.Click += new System.EventHandler(this.buttonDownloadAll_Click);
            // 
            // buttonLimitedDownload
            // 
            this.buttonLimitedDownload.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimitedDownload.ForeColor = System.Drawing.Color.DeepPink;
            this.buttonLimitedDownload.Location = new System.Drawing.Point(253, 166);
            this.buttonLimitedDownload.Name = "buttonLimitedDownload";
            this.buttonLimitedDownload.Size = new System.Drawing.Size(175, 63);
            this.buttonLimitedDownload.TabIndex = 2;
            this.buttonLimitedDownload.Text = "Limited Download";
            this.buttonLimitedDownload.UseVisualStyleBackColor = true;
            this.buttonLimitedDownload.Click += new System.EventHandler(this.buttonLimitedDownload_Click);
            // 
            // labelUpdateNumber
            // 
            this.labelUpdateNumber.AutoSize = true;
            this.labelUpdateNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateNumber.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelUpdateNumber.Location = new System.Drawing.Point(67, 254);
            this.labelUpdateNumber.Name = "labelUpdateNumber";
            this.labelUpdateNumber.Size = new System.Drawing.Size(329, 19);
            this.labelUpdateNumber.TabIndex = 4;
            this.labelUpdateNumber.Text = "The number of questions you want to update";
            // 
            // comboBoxUpdateNumber
            // 
            this.comboBoxUpdateNumber.FormattingEnabled = true;
            this.comboBoxUpdateNumber.Location = new System.Drawing.Point(402, 256);
            this.comboBoxUpdateNumber.Name = "comboBoxUpdateNumber";
            this.comboBoxUpdateNumber.Size = new System.Drawing.Size(162, 21);
            this.comboBoxUpdateNumber.TabIndex = 6;
            this.comboBoxUpdateNumber.SelectedIndexChanged += new System.EventHandler(this.comboBoxUpdateNumber_SelectedIndexChanged);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownload.ForeColor = System.Drawing.Color.DeepPink;
            this.buttonDownload.Location = new System.Drawing.Point(431, 283);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(133, 34);
            this.buttonDownload.TabIndex = 7;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.Black;
            this.buttonBack.Location = new System.Drawing.Point(41, 419);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(102, 47);
            this.buttonBack.TabIndex = 8;
            this.buttonBack.Text = "<< Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.DeepPink;
            this.buttonRefresh.Location = new System.Drawing.Point(253, 406);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(175, 60);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelDownloadStart
            // 
            this.labelDownloadStart.AutoSize = true;
            this.labelDownloadStart.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDownloadStart.ForeColor = System.Drawing.Color.Blue;
            this.labelDownloadStart.Location = new System.Drawing.Point(168, 100);
            this.labelDownloadStart.Name = "labelDownloadStart";
            this.labelDownloadStart.Size = new System.Drawing.Size(0, 35);
            this.labelDownloadStart.TabIndex = 10;
            // 
            // UpdateInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 502);
            this.Controls.Add(this.labelDownloadStart);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.comboBoxUpdateNumber);
            this.Controls.Add(this.labelUpdateNumber);
            this.Controls.Add(this.buttonLimitedDownload);
            this.Controls.Add(this.buttonDownloadAll);
            this.Controls.Add(this.labelTotalUpdate);
            this.Name = "UpdateInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateInformation";
            this.Load += new System.EventHandler(this.UpdateInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalUpdate;
        private System.Windows.Forms.Button buttonDownloadAll;
        private System.Windows.Forms.Button buttonLimitedDownload;
        private System.Windows.Forms.Label labelUpdateNumber;
        private System.Windows.Forms.ComboBox comboBoxUpdateNumber;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelDownloadStart;
    }
}
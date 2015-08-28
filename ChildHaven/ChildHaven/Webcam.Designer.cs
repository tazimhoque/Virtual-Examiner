namespace ChildHaven
{
    partial class Webcam
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonTakePicture = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.comboBoxPic = new System.Windows.Forms.ComboBox();
            this.pictureBoxPic = new System.Windows.Forms.PictureBox();
            this.saveFileDialogPic = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(80, 383);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(105, 39);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonTakePicture
            // 
            this.buttonTakePicture.Location = new System.Drawing.Point(265, 383);
            this.buttonTakePicture.Name = "buttonTakePicture";
            this.buttonTakePicture.Size = new System.Drawing.Size(112, 39);
            this.buttonTakePicture.TabIndex = 1;
            this.buttonTakePicture.Text = "Take Picture";
            this.buttonTakePicture.UseVisualStyleBackColor = true;
            this.buttonTakePicture.Click += new System.EventHandler(this.buttonTakePicture_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(450, 383);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(89, 39);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // comboBoxPic
            // 
            this.comboBoxPic.FormattingEnabled = true;
            this.comboBoxPic.Location = new System.Drawing.Point(80, 328);
            this.comboBoxPic.Name = "comboBoxPic";
            this.comboBoxPic.Size = new System.Drawing.Size(459, 21);
            this.comboBoxPic.TabIndex = 3;
            // 
            // pictureBoxPic
            // 
            this.pictureBoxPic.Location = new System.Drawing.Point(80, 12);
            this.pictureBoxPic.Name = "pictureBoxPic";
            this.pictureBoxPic.Size = new System.Drawing.Size(459, 295);
            this.pictureBoxPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPic.TabIndex = 4;
            this.pictureBoxPic.TabStop = false;
            // 
            // saveFileDialogPic
            // 
            this.saveFileDialogPic.Filter = "jpg Image |*.jpg";
            // 
            // Webcam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 468);
            this.Controls.Add(this.pictureBoxPic);
            this.Controls.Add(this.comboBoxPic);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonTakePicture);
            this.Controls.Add(this.buttonStart);
            this.Name = "Webcam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webcam";
            this.Load += new System.EventHandler(this.Webcam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonTakePicture;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ComboBox comboBoxPic;
        private System.Windows.Forms.PictureBox pictureBoxPic;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPic;
    }
}
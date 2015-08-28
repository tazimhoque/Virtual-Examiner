namespace ChildHaven
{
    partial class PictureQuestion
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
            this.labelUpperText = new System.Windows.Forms.Label();
            this.labelMainQuestion = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.pictureBoxPic = new System.Windows.Forms.PictureBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelQSN = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUpperText
            // 
            this.labelUpperText.AutoSize = true;
            this.labelUpperText.Location = new System.Drawing.Point(72, 19);
            this.labelUpperText.Name = "labelUpperText";
            this.labelUpperText.Size = new System.Drawing.Size(60, 13);
            this.labelUpperText.TabIndex = 0;
            this.labelUpperText.Text = "Upper Text";
            this.labelUpperText.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelMainQuestion
            // 
            this.labelMainQuestion.AutoSize = true;
            this.labelMainQuestion.Location = new System.Drawing.Point(72, 456);
            this.labelMainQuestion.Name = "labelMainQuestion";
            this.labelMainQuestion.Size = new System.Drawing.Size(75, 13);
            this.labelMainQuestion.TabIndex = 1;
            this.labelMainQuestion.Text = "Main Question";
            this.labelMainQuestion.Click += new System.EventHandler(this.labelMainQuestion_Click);
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer.ForeColor = System.Drawing.Color.Magenta;
            this.labelAnswer.Location = new System.Drawing.Point(71, 495);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(90, 22);
            this.labelAnswer.TabIndex = 2;
            this.labelAnswer.Text = "Answer :";
            // 
            // pictureBoxPic
            // 
            this.pictureBoxPic.Location = new System.Drawing.Point(75, 53);
            this.pictureBoxPic.Name = "pictureBoxPic";
            this.pictureBoxPic.Size = new System.Drawing.Size(414, 281);
            this.pictureBoxPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPic.TabIndex = 3;
            this.pictureBoxPic.TabStop = false;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(75, 340);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(604, 95);
            this.richTextBoxDescription.TabIndex = 4;
            this.richTextBoxDescription.Text = "";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(194, 497);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(311, 20);
            this.textBoxAnswer.TabIndex = 5;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(15, 565);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(80, 50);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "<<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(732, 565);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(80, 50);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Lucida Bright", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonSubmit.Location = new System.Drawing.Point(320, 565);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(185, 50);
            this.buttonSubmit.TabIndex = 8;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelQSN
            // 
            this.labelQSN.AutoSize = true;
            this.labelQSN.Location = new System.Drawing.Point(12, 19);
            this.labelQSN.Name = "labelQSN";
            this.labelQSN.Size = new System.Drawing.Size(30, 13);
            this.labelQSN.TabIndex = 9;
            this.labelQSN.Text = "QSN";
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.ForeColor = System.Drawing.Color.Blue;
            this.buttonQuit.Location = new System.Drawing.Point(677, 12);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(135, 50);
            this.buttonQuit.TabIndex = 10;
            this.buttonQuit.Text = "Quit Test";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // PictureQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 622);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.labelQSN);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.pictureBoxPic);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.labelMainQuestion);
            this.Controls.Add(this.labelUpperText);
            this.Name = "PictureQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureQuestion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUpperText;
        private System.Windows.Forms.Label labelMainQuestion;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.PictureBox pictureBoxPic;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelQSN;
        private System.Windows.Forms.Button buttonQuit;
    }
}
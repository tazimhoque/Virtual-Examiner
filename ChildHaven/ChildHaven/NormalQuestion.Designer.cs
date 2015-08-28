namespace ChildHaven
{
    partial class NormalQuestion
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMainQuestion = new System.Windows.Forms.Label();
            this.labelUpperText = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.labelQSN = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Lucida Bright", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonSubmit.Location = new System.Drawing.Point(320, 565);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(185, 50);
            this.buttonSubmit.TabIndex = 69;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(732, 565);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(80, 50);
            this.buttonNext.TabIndex = 68;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(15, 565);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(80, 50);
            this.buttonBack.TabIndex = 67;
            this.buttonBack.Text = "<<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(111, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 58;
            this.label1.Text = "Answer :";
            // 
            // labelMainQuestion
            // 
            this.labelMainQuestion.AutoSize = true;
            this.labelMainQuestion.Location = new System.Drawing.Point(112, 184);
            this.labelMainQuestion.Name = "labelMainQuestion";
            this.labelMainQuestion.Size = new System.Drawing.Size(75, 13);
            this.labelMainQuestion.TabIndex = 57;
            this.labelMainQuestion.Text = "Main Question";
            // 
            // labelUpperText
            // 
            this.labelUpperText.AutoSize = true;
            this.labelUpperText.Location = new System.Drawing.Point(112, 75);
            this.labelUpperText.Name = "labelUpperText";
            this.labelUpperText.Size = new System.Drawing.Size(60, 13);
            this.labelUpperText.TabIndex = 56;
            this.labelUpperText.Text = "Upper Text";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(246, 382);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(348, 20);
            this.textBoxAnswer.TabIndex = 70;
            // 
            // labelQSN
            // 
            this.labelQSN.AutoSize = true;
            this.labelQSN.Location = new System.Drawing.Point(12, 9);
            this.labelQSN.Name = "labelQSN";
            this.labelQSN.Size = new System.Drawing.Size(30, 13);
            this.labelQSN.TabIndex = 71;
            this.labelQSN.Text = "QSN";
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.ForeColor = System.Drawing.Color.Blue;
            this.buttonQuit.Location = new System.Drawing.Point(677, 12);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(135, 50);
            this.buttonQuit.TabIndex = 72;
            this.buttonQuit.Text = "Quit Test";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // NormalQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 622);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.labelQSN);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMainQuestion);
            this.Controls.Add(this.labelUpperText);
            this.Name = "NormalQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NormalQuestion";
            this.Load += new System.EventHandler(this.NormalQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMainQuestion;
        private System.Windows.Forms.Label labelUpperText;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label labelQSN;
        private System.Windows.Forms.Button buttonQuit;

    }
}
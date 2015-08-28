namespace ChildHaven
{
    partial class MathNormalQuestion
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
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.labelMainQuestion = new System.Windows.Forms.Label();
            this.labelUpperText = new System.Windows.Forms.Label();
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
            this.buttonSubmit.TabIndex = 17;
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
            this.buttonNext.TabIndex = 16;
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
            this.buttonBack.TabIndex = 15;
            this.buttonBack.Text = "<<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(215, 471);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(348, 20);
            this.textBoxAnswer.TabIndex = 14;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(75, 121);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(652, 247);
            this.richTextBoxDescription.TabIndex = 13;
            this.richTextBoxDescription.Text = "";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer.ForeColor = System.Drawing.Color.Magenta;
            this.labelAnswer.Location = new System.Drawing.Point(71, 469);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(90, 22);
            this.labelAnswer.TabIndex = 11;
            this.labelAnswer.Text = "Answer :";
            // 
            // labelMainQuestion
            // 
            this.labelMainQuestion.AutoSize = true;
            this.labelMainQuestion.Location = new System.Drawing.Point(72, 407);
            this.labelMainQuestion.Name = "labelMainQuestion";
            this.labelMainQuestion.Size = new System.Drawing.Size(75, 13);
            this.labelMainQuestion.TabIndex = 10;
            this.labelMainQuestion.Text = "Main Question";
            // 
            // labelUpperText
            // 
            this.labelUpperText.AutoSize = true;
            this.labelUpperText.Location = new System.Drawing.Point(72, 56);
            this.labelUpperText.Name = "labelUpperText";
            this.labelUpperText.Size = new System.Drawing.Size(60, 13);
            this.labelUpperText.TabIndex = 9;
            this.labelUpperText.Text = "Upper Text";
            // 
            // labelQSN
            // 
            this.labelQSN.AutoSize = true;
            this.labelQSN.Location = new System.Drawing.Point(12, 9);
            this.labelQSN.Name = "labelQSN";
            this.labelQSN.Size = new System.Drawing.Size(30, 13);
            this.labelQSN.TabIndex = 38;
            this.labelQSN.Text = "QSN";
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.ForeColor = System.Drawing.Color.Blue;
            this.buttonQuit.Location = new System.Drawing.Point(677, 12);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(135, 50);
            this.buttonQuit.TabIndex = 43;
            this.buttonQuit.Text = "Quit Test";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // MathNormalQuestion
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
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.labelMainQuestion);
            this.Controls.Add(this.labelUpperText);
            this.Name = "MathNormalQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MathNormalQuestion";
            this.Load += new System.EventHandler(this.MathNormalQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Label labelMainQuestion;
        private System.Windows.Forms.Label labelUpperText;
        private System.Windows.Forms.Label labelQSN;
        private System.Windows.Forms.Button buttonQuit;
    }
}
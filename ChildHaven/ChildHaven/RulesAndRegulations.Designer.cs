namespace ChildHaven
{
    partial class RulesAndRegulations
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelQuestionNumbers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGetReady = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question Paper is downloading.....\r\nPlease Wait...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(602, 618);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 768);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // labelQuestionNumbers
            // 
            this.labelQuestionNumbers.AutoSize = true;
            this.labelQuestionNumbers.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestionNumbers.ForeColor = System.Drawing.Color.Red;
            this.labelQuestionNumbers.Location = new System.Drawing.Point(111, 135);
            this.labelQuestionNumbers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuestionNumbers.Name = "labelQuestionNumbers";
            this.labelQuestionNumbers.Size = new System.Drawing.Size(415, 40);
            this.labelQuestionNumbers.TabIndex = 3;
            this.labelQuestionNumbers.Text = "There are 10 Questions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(224, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(468, 203);
            this.label5.TabIndex = 4;
            this.label5.Text = "*  Each Question Contains 5 Marks\r\n\r\n*  Wrong Answer Penalty 2 Marks\r\n\r\n*  If you" +
    " don\'t want to answer any \r\n     question just keep the answer\r\n      blank and " +
    "press submit.";
            // 
            // buttonGetReady
            // 
            this.buttonGetReady.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetReady.ForeColor = System.Drawing.Color.Indigo;
            this.buttonGetReady.Location = new System.Drawing.Point(304, 430);
            this.buttonGetReady.Name = "buttonGetReady";
            this.buttonGetReady.Size = new System.Drawing.Size(303, 78);
            this.buttonGetReady.TabIndex = 5;
            this.buttonGetReady.Text = "GET  READY >>";
            this.buttonGetReady.UseVisualStyleBackColor = true;
            this.buttonGetReady.Click += new System.EventHandler(this.buttonGetReady_Click);
            // 
            // RulesAndRegulations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 520);
            this.Controls.Add(this.buttonGetReady);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelQuestionNumbers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RulesAndRegulations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rules And Regulations";
            this.Load += new System.EventHandler(this.RulesAndRegulations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelQuestionNumbers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGetReady;
    }
}
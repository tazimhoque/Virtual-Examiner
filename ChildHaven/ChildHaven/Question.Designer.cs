namespace ChildHaven
{
    partial class Question
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUnsolved = new System.Windows.Forms.Button();
            this.buttonAllProblem = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Marker", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(561, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Online Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUnsolved
            // 
            this.buttonUnsolved.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUnsolved.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonUnsolved.Location = new System.Drawing.Point(117, 190);
            this.buttonUnsolved.Name = "buttonUnsolved";
            this.buttonUnsolved.Size = new System.Drawing.Size(561, 100);
            this.buttonUnsolved.TabIndex = 1;
            this.buttonUnsolved.Text = "Unsolved Problems";
            this.buttonUnsolved.UseVisualStyleBackColor = true;
            this.buttonUnsolved.Click += new System.EventHandler(this.buttonUnsolved_Click);
            // 
            // buttonAllProblem
            // 
            this.buttonAllProblem.Font = new System.Drawing.Font("Lucida Bright", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllProblem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonAllProblem.Location = new System.Drawing.Point(245, 314);
            this.buttonAllProblem.Name = "buttonAllProblem";
            this.buttonAllProblem.Size = new System.Drawing.Size(561, 100);
            this.buttonAllProblem.TabIndex = 2;
            this.buttonAllProblem.Text = "All Problems";
            this.buttonAllProblem.UseVisualStyleBackColor = true;
            this.buttonAllProblem.Click += new System.EventHandler(this.buttonAllProblem_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(12, 444);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 64);
            this.button4.TabIndex = 3;
            this.button4.Text = "<<Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(719, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 43);
            this.button5.TabIndex = 4;
            this.button5.Text = "Sign Out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 540);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonAllProblem);
            this.Controls.Add(this.buttonUnsolved);
            this.Controls.Add(this.button1);
            this.Name = "Question";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUnsolved;
        private System.Windows.Forms.Button buttonAllProblem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}
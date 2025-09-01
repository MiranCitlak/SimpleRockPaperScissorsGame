namespace RockPaperScissorsMiniGame
{
    partial class Form1
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
            this.Scissors = new System.Windows.Forms.Button();
            this.Rock = new System.Windows.Forms.Button();
            this.Paper = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Scissors
            // 
            this.Scissors.BackColor = System.Drawing.Color.LightPink;
            this.Scissors.Font = new System.Drawing.Font("Ink Free", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Scissors.ForeColor = System.Drawing.Color.LemonChiffon;
            this.Scissors.Location = new System.Drawing.Point(610, 750);
            this.Scissors.Name = "Scissors";
            this.Scissors.Size = new System.Drawing.Size(280, 100);
            this.Scissors.TabIndex = 1;
            this.Scissors.Text = "Scissors";
            this.Scissors.UseVisualStyleBackColor = false;
            // 
            // Rock
            // 
            this.Rock.BackColor = System.Drawing.Color.LightPink;
            this.Rock.Font = new System.Drawing.Font("Ink Free", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rock.ForeColor = System.Drawing.Color.LemonChiffon;
            this.Rock.Location = new System.Drawing.Point(610, 530);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(280, 100);
            this.Rock.TabIndex = 2;
            this.Rock.Text = "Rock";
            this.Rock.UseVisualStyleBackColor = false;
            // 
            // Paper
            // 
            this.Paper.BackColor = System.Drawing.Color.LightPink;
            this.Paper.Font = new System.Drawing.Font("Ink Free", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Paper.ForeColor = System.Drawing.Color.LemonChiffon;
            this.Paper.Location = new System.Drawing.Point(610, 640);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(280, 100);
            this.Paper.TabIndex = 3;
            this.Paper.Text = "Paper";
            this.Paper.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Location = new System.Drawing.Point(146, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 448);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1478, 944);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Paper);
            this.Controls.Add(this.Rock);
            this.Controls.Add(this.Scissors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Scissors;
        private System.Windows.Forms.Button Rock;
        private System.Windows.Forms.Button Paper;
        private System.Windows.Forms.Panel panel1;
    }
}


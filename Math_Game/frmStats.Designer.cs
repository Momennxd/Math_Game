namespace Math_Game
{
    partial class frmStats
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
            this.lblNumOfRightQuestions = new System.Windows.Forms.Label();
            this.lblNumOfWrongQuestions = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIsPassed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(260, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Of Right Questions";
            // 
            // lblNumOfRightQuestions
            // 
            this.lblNumOfRightQuestions.AutoSize = true;
            this.lblNumOfRightQuestions.BackColor = System.Drawing.Color.Transparent;
            this.lblNumOfRightQuestions.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfRightQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNumOfRightQuestions.Location = new System.Drawing.Point(380, 174);
            this.lblNumOfRightQuestions.Name = "lblNumOfRightQuestions";
            this.lblNumOfRightQuestions.Size = new System.Drawing.Size(23, 25);
            this.lblNumOfRightQuestions.TabIndex = 1;
            this.lblNumOfRightQuestions.Text = "0";
            // 
            // lblNumOfWrongQuestions
            // 
            this.lblNumOfWrongQuestions.AutoSize = true;
            this.lblNumOfWrongQuestions.BackColor = System.Drawing.Color.Transparent;
            this.lblNumOfWrongQuestions.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfWrongQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNumOfWrongQuestions.Location = new System.Drawing.Point(390, 313);
            this.lblNumOfWrongQuestions.Name = "lblNumOfWrongQuestions";
            this.lblNumOfWrongQuestions.Size = new System.Drawing.Size(23, 25);
            this.lblNumOfWrongQuestions.TabIndex = 3;
            this.lblNumOfWrongQuestions.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(260, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number Of Wrong Questions";
            // 
            // lblIsPassed
            // 
            this.lblIsPassed.AutoSize = true;
            this.lblIsPassed.BackColor = System.Drawing.Color.Transparent;
            this.lblIsPassed.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsPassed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIsPassed.Location = new System.Drawing.Point(369, 409);
            this.lblIsPassed.Name = "lblIsPassed";
            this.lblIsPassed.Size = new System.Drawing.Size(76, 25);
            this.lblIsPassed.TabIndex = 4;
            this.lblIsPassed.Text = "Passed";
            // 
            // frmStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Math_Game.Properties.Resources.background_3909536;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 556);
            this.Controls.Add(this.lblIsPassed);
            this.Controls.Add(this.lblNumOfWrongQuestions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumOfRightQuestions);
            this.Controls.Add(this.label1);
            this.Name = "frmStats";
            this.Text = "Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblNumOfRightQuestions;
        public System.Windows.Forms.Label lblNumOfWrongQuestions;
        public System.Windows.Forms.Label lblIsPassed;
    }
}
namespace Math_Game
{
    partial class Game_Screen
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentQuestion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumberOfQuestions = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.lblQuesType = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGoBackToMainMenu = new System.Windows.Forms.Button();
            this.QuestionsTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question";
            // 
            // lblCurrentQuestion
            // 
            this.lblCurrentQuestion.AutoSize = true;
            this.lblCurrentQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCurrentQuestion.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQuestion.ForeColor = System.Drawing.Color.DimGray;
            this.lblCurrentQuestion.Location = new System.Drawing.Point(529, 9);
            this.lblCurrentQuestion.Name = "lblCurrentQuestion";
            this.lblCurrentQuestion.Size = new System.Drawing.Size(40, 44);
            this.lblCurrentQuestion.TabIndex = 1;
            this.lblCurrentQuestion.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(590, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Out Of";
            // 
            // lblNumberOfQuestions
            // 
            this.lblNumberOfQuestions.AutoSize = true;
            this.lblNumberOfQuestions.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumberOfQuestions.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfQuestions.ForeColor = System.Drawing.Color.DimGray;
            this.lblNumberOfQuestions.Location = new System.Drawing.Point(738, 9);
            this.lblNumberOfQuestions.Name = "lblNumberOfQuestions";
            this.lblNumberOfQuestions.Size = new System.Drawing.Size(61, 44);
            this.lblNumberOfQuestions.TabIndex = 3;
            this.lblNumberOfQuestions.Text = "10";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumber2.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNumber2.Location = new System.Drawing.Point(715, 144);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(160, 114);
            this.lblNumber2.TabIndex = 4;
            this.lblNumber2.Text = "10";
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNumber1.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNumber1.Location = new System.Drawing.Point(322, 144);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(160, 114);
            this.lblNumber1.TabIndex = 5;
            this.lblNumber1.Text = "63";
            // 
            // lblQuesType
            // 
            this.lblQuesType.AutoSize = true;
            this.lblQuesType.BackColor = System.Drawing.Color.Transparent;
            this.lblQuesType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuesType.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuesType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuesType.Location = new System.Drawing.Point(546, 144);
            this.lblQuesType.Name = "lblQuesType";
            this.lblQuesType.Size = new System.Drawing.Size(104, 114);
            this.lblQuesType.TabIndex = 6;
            this.lblQuesType.Text = "+";
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnswer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAnswer.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.ForeColor = System.Drawing.Color.DarkGray;
            this.txtAnswer.Location = new System.Drawing.Point(448, 366);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtAnswer.Size = new System.Drawing.Size(271, 104);
            this.txtAnswer.TabIndex = 8;
            this.txtAnswer.Text = "55";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Transparent;
            this.btnCheck.BackgroundImage = global::Math_Game.Properties.Resources.Confirm_mark_edit_1;
            this.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.Transparent;
            this.btnCheck.Location = new System.Drawing.Point(532, 488);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(118, 98);
            this.btnCheck.TabIndex = 9;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(277, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(598, 114);
            this.label3.TabIndex = 10;
            this.label3.Text = "----------------------";
            // 
            // btnGoBackToMainMenu
            // 
            this.btnGoBackToMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnGoBackToMainMenu.BackgroundImage = global::Math_Game.Properties.Resources._9244315;
            this.btnGoBackToMainMenu.ForeColor = System.Drawing.Color.Transparent;
            this.btnGoBackToMainMenu.Location = new System.Drawing.Point(20, 21);
            this.btnGoBackToMainMenu.Name = "btnGoBackToMainMenu";
            this.btnGoBackToMainMenu.Size = new System.Drawing.Size(129, 127);
            this.btnGoBackToMainMenu.TabIndex = 11;
            this.btnGoBackToMainMenu.UseVisualStyleBackColor = false;
            this.btnGoBackToMainMenu.Click += new System.EventHandler(this.btnGoBackToMainMenu_Click);
            // 
            // QuestionsTimer
            // 
            this.QuestionsTimer.Interval = 1000;
            this.QuestionsTimer.Tick += new System.EventHandler(this.QuestionsTimer_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimer.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTimer.Location = new System.Drawing.Point(984, 34);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(104, 114);
            this.lblTimer.TabIndex = 12;
            this.lblTimer.Text = "0";
            // 
            // Game_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Math_Game.Properties.Resources.wall_2640737;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 741);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnGoBackToMainMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblQuesType);
            this.Controls.Add(this.lblNumber1);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumberOfQuestions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCurrentQuestion);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Game_Screen";
            this.Text = "Game_Screen";
            this.Load += new System.EventHandler(this.Game_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumberOfQuestions;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label lblQuesType;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGoBackToMainMenu;
        private System.Windows.Forms.Timer QuestionsTimer;
        private System.Windows.Forms.Label lblTimer;
    }
}
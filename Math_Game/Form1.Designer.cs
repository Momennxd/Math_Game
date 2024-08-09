namespace Math_Game
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtQuestionTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumberOfQuestions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbQuestionsType = new System.Windows.Forms.GroupBox();
            this.chkSubtraction = new System.Windows.Forms.CheckBox();
            this.chkDivide = new System.Windows.Forms.CheckBox();
            this.chkAddition = new System.Windows.Forms.CheckBox();
            this.chkMultiply = new System.Windows.Forms.CheckBox();
            this.gbDifficultySettings = new System.Windows.Forms.GroupBox();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbSettings.SuspendLayout();
            this.gbQuestionsType.SuspendLayout();
            this.gbDifficultySettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(229, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(447, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "The Math Game";
            // 
            // gbSettings
            // 
            this.gbSettings.BackColor = System.Drawing.Color.Silver;
            this.gbSettings.Controls.Add(this.btnStart);
            this.gbSettings.Controls.Add(this.txtQuestionTime);
            this.gbSettings.Controls.Add(this.label2);
            this.gbSettings.Controls.Add(this.txtNumberOfQuestions);
            this.gbSettings.Controls.Add(this.label1);
            this.gbSettings.Controls.Add(this.gbQuestionsType);
            this.gbSettings.Controls.Add(this.gbDifficultySettings);
            this.gbSettings.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSettings.ForeColor = System.Drawing.Color.Black;
            this.gbSettings.Location = new System.Drawing.Point(114, 131);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(666, 474);
            this.gbSettings.TabIndex = 1;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkGray;
            this.btnStart.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStart.Location = new System.Drawing.Point(401, 309);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(182, 120);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtQuestionTime
            // 
            this.txtQuestionTime.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtQuestionTime.Location = new System.Drawing.Point(406, 234);
            this.txtQuestionTime.MaxLength = 60;
            this.txtQuestionTime.Name = "txtQuestionTime";
            this.txtQuestionTime.Size = new System.Drawing.Size(167, 32);
            this.txtQuestionTime.TabIndex = 8;
            this.txtQuestionTime.Tag = "";
            this.txtQuestionTime.Text = "30";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 75);
            this.label2.TabIndex = 7;
            this.label2.Text = "Each Question\'s Time\r\n       (In Seconds)\r\n\r\n";
            // 
            // txtNumberOfQuestions
            // 
            this.txtNumberOfQuestions.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNumberOfQuestions.Location = new System.Drawing.Point(406, 93);
            this.txtNumberOfQuestions.MaxLength = 50;
            this.txtNumberOfQuestions.Name = "txtNumberOfQuestions";
            this.txtNumberOfQuestions.Size = new System.Drawing.Size(167, 32);
            this.txtNumberOfQuestions.TabIndex = 6;
            this.txtNumberOfQuestions.Tag = "";
            this.txtNumberOfQuestions.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number Of Questions";
            // 
            // gbQuestionsType
            // 
            this.gbQuestionsType.BackColor = System.Drawing.Color.DarkGray;
            this.gbQuestionsType.Controls.Add(this.chkSubtraction);
            this.gbQuestionsType.Controls.Add(this.chkDivide);
            this.gbQuestionsType.Controls.Add(this.chkAddition);
            this.gbQuestionsType.Controls.Add(this.chkMultiply);
            this.gbQuestionsType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbQuestionsType.Location = new System.Drawing.Point(18, 249);
            this.gbQuestionsType.Name = "gbQuestionsType";
            this.gbQuestionsType.Size = new System.Drawing.Size(274, 219);
            this.gbQuestionsType.TabIndex = 4;
            this.gbQuestionsType.TabStop = false;
            this.gbQuestionsType.Text = "Questions Type";
            // 
            // chkSubtraction
            // 
            this.chkSubtraction.AutoSize = true;
            this.chkSubtraction.Location = new System.Drawing.Point(28, 180);
            this.chkSubtraction.Name = "chkSubtraction";
            this.chkSubtraction.Size = new System.Drawing.Size(181, 29);
            this.chkSubtraction.TabIndex = 8;
            this.chkSubtraction.Text = "Subtraction";
            this.chkSubtraction.UseVisualStyleBackColor = true;
            // 
            // chkDivide
            // 
            this.chkDivide.AutoSize = true;
            this.chkDivide.Location = new System.Drawing.Point(28, 86);
            this.chkDivide.Name = "chkDivide";
            this.chkDivide.Size = new System.Drawing.Size(106, 29);
            this.chkDivide.TabIndex = 6;
            this.chkDivide.Text = "Divide";
            this.chkDivide.UseVisualStyleBackColor = true;
            // 
            // chkAddition
            // 
            this.chkAddition.AutoSize = true;
            this.chkAddition.Location = new System.Drawing.Point(28, 133);
            this.chkAddition.Name = "chkAddition";
            this.chkAddition.Size = new System.Drawing.Size(135, 29);
            this.chkAddition.TabIndex = 7;
            this.chkAddition.Text = "Addition";
            this.chkAddition.UseVisualStyleBackColor = true;
            // 
            // chkMultiply
            // 
            this.chkMultiply.AutoSize = true;
            this.chkMultiply.Checked = true;
            this.chkMultiply.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMultiply.Location = new System.Drawing.Point(28, 39);
            this.chkMultiply.Name = "chkMultiply";
            this.chkMultiply.Size = new System.Drawing.Size(137, 29);
            this.chkMultiply.TabIndex = 5;
            this.chkMultiply.Text = "Multiply";
            this.chkMultiply.UseVisualStyleBackColor = true;
            // 
            // gbDifficultySettings
            // 
            this.gbDifficultySettings.BackColor = System.Drawing.Color.DarkGray;
            this.gbDifficultySettings.Controls.Add(this.rbHard);
            this.gbDifficultySettings.Controls.Add(this.rbMeduim);
            this.gbDifficultySettings.Controls.Add(this.rbEasy);
            this.gbDifficultySettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDifficultySettings.Location = new System.Drawing.Point(18, 43);
            this.gbDifficultySettings.Name = "gbDifficultySettings";
            this.gbDifficultySettings.Size = new System.Drawing.Size(274, 188);
            this.gbDifficultySettings.TabIndex = 0;
            this.gbDifficultySettings.TabStop = false;
            this.gbDifficultySettings.Text = "Difficulty Settings";
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Location = new System.Drawing.Point(28, 137);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(92, 29);
            this.rbHard.TabIndex = 2;
            this.rbHard.TabStop = true;
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Location = new System.Drawing.Point(28, 95);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(116, 29);
            this.rbMeduim.TabIndex = 3;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Location = new System.Drawing.Point(28, 53);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(84, 29);
            this.rbEasy.TabIndex = 1;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(918, 662);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            this.gbQuestionsType.ResumeLayout(false);
            this.gbQuestionsType.PerformLayout();
            this.gbDifficultySettings.ResumeLayout(false);
            this.gbDifficultySettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.GroupBox gbDifficultySettings;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbQuestionsType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.RadioButton rbHard;
        public System.Windows.Forms.RadioButton rbMeduim;
        public System.Windows.Forms.RadioButton rbEasy;
        public System.Windows.Forms.CheckBox chkSubtraction;
        public System.Windows.Forms.CheckBox chkDivide;
        public System.Windows.Forms.CheckBox chkAddition;
        public System.Windows.Forms.CheckBox chkMultiply;
        public System.Windows.Forms.TextBox txtQuestionTime;
        public System.Windows.Forms.TextBox txtNumberOfQuestions;
    }
}


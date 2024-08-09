using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Math_Game.Form1;

namespace Math_Game
{
    public partial class Game_Screen : Form
    {
        public Game_Screen()
        {
            InitializeComponent();
        }

        struct stEachQuestionDetails
        {
            public int Number1;
            public int Number2;
            public string QuesSymbols;
            public int RightAnswer;
        }

        public class clsStatistics
        {
            public int NumberOfRightAnswers;
            public int NumberOfWrongAnswers;
            public bool IsPassed;

            public clsStatistics(int cNumberOfRightAnswers, int cNumberOfWrongAnswers, bool cIsPassed)
            {
                NumberOfRightAnswers = cNumberOfRightAnswers;
                NumberOfWrongAnswers = cNumberOfWrongAnswers;
                IsPassed = cIsPassed;
            }
        }


        public Form1.clsQuestionsInfo frm2QuestionsInfo = new Form1.clsQuestionsInfo();

        stEachQuestionDetails EachQuestionDetails = new stEachQuestionDetails();

        string[] arrQuestionsSymbols = new string[4];

        byte NumberOfPossibleSymbols = 0;
        byte NumOfCurrentQuestion = 0;
        int NumOTheRemainingQuestion = 0;
        short TimeCounter = 0;
        public clsStatistics cStats = new clsStatistics(0, 0, false);


        void FillArrayWithQuestoinsSymbols()
        {
            
            if (frm2QuestionsInfo.Add)
            {
                arrQuestionsSymbols[NumberOfPossibleSymbols]  = "+";
                NumberOfPossibleSymbols++;
            }

            if (frm2QuestionsInfo.Sub)
            {
                arrQuestionsSymbols[NumberOfPossibleSymbols] = "-";
                NumberOfPossibleSymbols++;
            }

            if (frm2QuestionsInfo.Divide)
            {              
                arrQuestionsSymbols[NumberOfPossibleSymbols] = "÷";
                NumberOfPossibleSymbols++;
            }

            if (frm2QuestionsInfo.Multiply)
            {              
                arrQuestionsSymbols[NumberOfPossibleSymbols] = "X";
            }

        }

        int GetTheRightAnswer(int Num1, int Num2, string Symbol)
        {
           
            switch (Symbol)
            {
                case "+":
                    return (Num1 + Num2);

                case "-":
                    return (Num1 - Num2);

                case "÷":
                    return (Num1 / Num2);

                case "X":
                    return (Num1 * Num2);

                default:
                    return (Num1 + Num2);

            }

        }

        void ShowQuestionsOnScreen()
        {
            lblNumber1.Text = EachQuestionDetails.Number1.ToString();
            lblNumber2.Text = EachQuestionDetails.Number2.ToString();
            lblQuesType.Text = EachQuestionDetails.QuesSymbols.ToString();
            lblNumberOfQuestions.Text = frm2QuestionsInfo.NumberOfQuestions.ToString();
            lblCurrentQuestion.Text = NumOfCurrentQuestion.ToString();
            txtAnswer.Text = "";
            txtAnswer.Focus();

        }

        bool IsAnswerRight(int RightAnswer) 
        {
            if (txtAnswer.Text.Trim() == RightAnswer.ToString())
            {
                cStats.NumberOfRightAnswers++;
                return true;
            }

            cStats.NumberOfWrongAnswers++;
            return false;
                    
        }

        void GetQuestions(int From, int To)
        {
          
            Random rnd = new Random();

            do
            {
                EachQuestionDetails.Number1 = rnd.Next(From, To);
                EachQuestionDetails.Number2 = rnd.Next(From, To);

            } while (EachQuestionDetails.Number1 < EachQuestionDetails.Number2);
           

            FillArrayWithQuestoinsSymbols();


            EachQuestionDetails.QuesSymbols = arrQuestionsSymbols[rnd.Next(0, NumberOfPossibleSymbols)];

            EachQuestionDetails.RightAnswer =
                GetTheRightAnswer(EachQuestionDetails.Number1,
                EachQuestionDetails.Number2, EachQuestionDetails.QuesSymbols);

            NumOfCurrentQuestion++;


            ShowQuestionsOnScreen();

            NumberOfPossibleSymbols = 0;
            NumOTheRemainingQuestion--;

           
        }

        void ShowStatics()
        {          
            frmStats frmStats  = new frmStats();
            frmStats.lblNumOfRightQuestions.Text = cStats.NumberOfRightAnswers.ToString();
            frmStats.lblNumOfWrongQuestions.Text = cStats.NumberOfWrongAnswers.ToString();

            if (cStats.NumberOfRightAnswers >= cStats.NumberOfWrongAnswers)
            {
                frmStats.lblIsPassed.ForeColor = Color.Green;
                frmStats.lblIsPassed.Text = "Passed";

            }
            else
            {
                frmStats.lblIsPassed.ForeColor = Color.Red;
                frmStats.lblIsPassed.Text = "Failed";
            }

            frmStats.ShowDialog();


        }

        private void GenerateQuestions(Form1.enDifficulty Difficulty)
        {
            QuestionsTimer.Enabled = true;

            switch (Difficulty)
            {
                case enDifficulty.eEasy:
                    GetQuestions(1,9);
                    break;

                case enDifficulty.eMeduim:
                    GetQuestions(11, 99);
                    break;

                case enDifficulty.eHard:
                    GetQuestions(100, 999);
                    break;

                default:
                    break;
            }

        }

        private void Game_Screen_Load(object sender, EventArgs e)
        {
            QuestionsTimer.Enabled = true;
            NumOTheRemainingQuestion = frm2QuestionsInfo.NumberOfQuestions;
            GenerateQuestions(frm2QuestionsInfo.Mode);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            QuestionsTimer.Enabled = false;
            TimeCounter = 0;

            if (IsAnswerRight(EachQuestionDetails.RightAnswer))
            {
                MessageBox.Show("The Answer Is Right", "Correct", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("The Answer Is Wrong\n\nThe Right Answer Is " + EachQuestionDetails.RightAnswer,
                    "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);              
            }

            if (NumOTheRemainingQuestion == 0)
            {
                if (MessageBox.Show("End Of The Test\n\nDo You Want To Show Stats ?", "The End", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ShowStatics();
                }

                txtAnswer.Text = "";
                txtAnswer.ReadOnly = true;
                btnCheck.Enabled = false;              
            }
            else
            {             
                GenerateQuestions(frm2QuestionsInfo.Mode);
            }



        }

        private void btnGoBackToMainMenu_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Are You Sure You Wanna Go Back To Main Menu ?","Go Back To Main Menu",
                MessageBoxButtons.OKCancel)
                == DialogResult.OK)
            {
                QuestionsTimer.Enabled = false;
                TimeCounter = 0;
                this.Close();
            }
            
        }

        private void QuestionsTimer_Tick(object sender, EventArgs e)
        {         
            TimeCounter++;
            lblTimer.Text = TimeCounter.ToString();
            lblTimer.Refresh();

            if (TimeCounter == frm2QuestionsInfo.EachQuestionTime)
            {                              
                btnCheck_Click(sender, e);
                TimeCounter = 0;
                
            }

          
           

        }
    }
}

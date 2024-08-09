using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum enDifficulty
        {
            eEasy,
            eMeduim,
            eHard
        }

        public class clsQuestionsInfo
        { 
            public bool Add, Sub, Divide, Multiply;
            public int NumberOfQuestions;
            public short EachQuestionTime;
            public enDifficulty Mode;
            public clsQuestionsInfo() 
            {
                Add = false;
                Sub = false;
                Divide = false;
                Multiply = false;

                NumberOfQuestions = 0;
                Mode = enDifficulty.eEasy;
                EachQuestionTime = 0;
            }

        }

        public clsQuestionsInfo QuestionsInfo = new clsQuestionsInfo();

        public void SaveSettings()
        {
            //setting game mode.
            if (rbEasy.Checked)
                QuestionsInfo.Mode = enDifficulty.eEasy;

            if (rbMeduim.Checked)
                QuestionsInfo.Mode = enDifficulty.eMeduim;

            if (rbHard.Checked)
                QuestionsInfo.Mode = enDifficulty.eHard;

            //setting the questions type.
            if (chkAddition.Checked)
                QuestionsInfo.Add = true;

            if (chkSubtraction.Checked)
                QuestionsInfo.Sub = true;

            if (chkMultiply.Checked)
                QuestionsInfo.Multiply = true;

            if (chkDivide.Checked)
                QuestionsInfo.Divide = true;


            if (string.IsNullOrEmpty(txtNumberOfQuestions.Text))
            {
                txtNumberOfQuestions.Text = 0.ToString();
            }

            QuestionsInfo.NumberOfQuestions = Convert.ToInt16(txtNumberOfQuestions.Text);


            if (string.IsNullOrEmpty(txtQuestionTime.Text))
            {
                txtQuestionTime.Text = 0.ToString();
            }

            QuestionsInfo.EachQuestionTime = Convert.ToInt16(txtQuestionTime.Text);



        }

        public void SaveSettingsTo_Game_Screen(Game_Screen GameScreen)
        {
            //setting game mode.
            if (rbEasy.Checked)
                GameScreen.frm2QuestionsInfo.Mode = enDifficulty.eEasy;

            if (rbMeduim.Checked)
                GameScreen.frm2QuestionsInfo.Mode = enDifficulty.eMeduim;

            if (rbHard.Checked)
                GameScreen.frm2QuestionsInfo.Mode = enDifficulty.eHard;

            //setting the questions type.
            if (chkAddition.Checked)
                GameScreen.frm2QuestionsInfo.Add = true;

            if (chkSubtraction.Checked)
                GameScreen.frm2QuestionsInfo.Sub = true;

            if (chkMultiply.Checked)
                GameScreen.frm2QuestionsInfo.Multiply = true;

            if (chkDivide.Checked)
                GameScreen.frm2QuestionsInfo.Divide = true;            

            GameScreen.frm2QuestionsInfo.NumberOfQuestions = Convert.ToInt16(txtNumberOfQuestions.Text);


            GameScreen.frm2QuestionsInfo.EachQuestionTime = Convert.ToInt16(txtQuestionTime.Text);



        }

        bool AreSettingsValid()
        {
            if (QuestionsInfo.Multiply == false &&
                QuestionsInfo.Sub == false &&
                QuestionsInfo.Add == false &&
                QuestionsInfo.Add == false)
            {
                return false;
            }

            if (QuestionsInfo.NumberOfQuestions == 0 ||
                QuestionsInfo.EachQuestionTime == 0)
            {
                return false;
            }

            return true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SaveSettings();

            if (!AreSettingsValid())
            {
                MessageBox.Show("Please Enter The Rest Of The Info");
                return;
            }
            
            Game_Screen GameScreen = new Game_Screen();
            SaveSettingsTo_Game_Screen(GameScreen);
            GameScreen.ShowDialog();
            
        }
    }
}

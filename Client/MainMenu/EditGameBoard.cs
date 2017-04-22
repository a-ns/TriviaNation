using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkLayer;
using GameComponents;

namespace GUILayer
{
    public partial class EditGameBoard : Form
    {
        Button CurrentQuestion;
        private int currentQNum;
        Tile[] tiles;
        private int NumberOfQuestions = 32;
        private int NumberOfAnswers = 4;
        public EditGameBoard()
        {
            this.tiles = new Tile[NumberOfQuestions];
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                this.tiles[i] = new Tile();
                this.tiles[i].answers = new Answer[NumberOfAnswers];
                for (int j = 0; j < NumberOfAnswers; j++)
                    this.tiles[i].answers[j] = new Answer();
            }
            InitializeComponent();
            this.CurrentQuestion = this.tile0;
        }

        private void nation0_Click(object sender, EventArgs e)
        {

        }

        private void nation1_Click(object sender, EventArgs e)
        {

        }

        private void nation2_Click(object sender, EventArgs e)
        {

        }

        private void nation3_Click(object sender, EventArgs e)
        {

        }

        private void tile0_Click(object sender, EventArgs e)
        {
            this.currentQNum = 0;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile0;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile1_Click(object sender, EventArgs e)
        {
            this.currentQNum = 1;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile1;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile2_Click(object sender, EventArgs e)
        {
            this.currentQNum = 2;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile2;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile3_Click(object sender, EventArgs e)
        {
            this.currentQNum = 3;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile3;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile4_Click(object sender, EventArgs e)
        {
            this.currentQNum = 4;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile4;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile5_Click(object sender, EventArgs e)
        {
            this.currentQNum = 5;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile5;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile6_Click(object sender, EventArgs e)
        {
            this.currentQNum = 6;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile6;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile7_Click(object sender, EventArgs e)
        {
            this.currentQNum = 7;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile7;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile8_Click(object sender, EventArgs e)
        {
            this.currentQNum = 8;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile8;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile9_Click(object sender, EventArgs e)
        {
            this.currentQNum = 9;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile9;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile10_Click(object sender, EventArgs e)
        {
            this.currentQNum = 10;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile10;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile11_Click(object sender, EventArgs e)
        {
            this.currentQNum = 11;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile11;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile12_Click(object sender, EventArgs e)
        {
            this.currentQNum = 12;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile12;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile13_Click(object sender, EventArgs e)
        {
            this.currentQNum = 13;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile13;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile14_Click(object sender, EventArgs e)
        {
            this.currentQNum = 14;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile14;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile15_Click(object sender, EventArgs e)
        {
            this.currentQNum = 15;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile15;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile16_Click(object sender, EventArgs e)
        {
            this.currentQNum = 16;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile16;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile17_Click(object sender, EventArgs e)
        {
            this.currentQNum = 17;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile17;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile18_Click(object sender, EventArgs e)
        {
            this.currentQNum = 18;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile18;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile19_Click(object sender, EventArgs e)
        {
            this.currentQNum = 19;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile19;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile20_Click(object sender, EventArgs e)
        {
            this.currentQNum = 20;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile20;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile21_Click(object sender, EventArgs e)
        {
            this.currentQNum = 21;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile21;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile22_Click(object sender, EventArgs e)
        {
            this.currentQNum = 22;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile22;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile23_Click(object sender, EventArgs e)
        {
            this.currentQNum = 23;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile23;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile24_Click(object sender, EventArgs e)
        {
            this.currentQNum = 24;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile24;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile25_Click(object sender, EventArgs e)
        {
            this.currentQNum = 25;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile25;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile26_Click(object sender, EventArgs e)
        {
            this.currentQNum = 26;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile26;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile27_Click(object sender, EventArgs e)
        {
            this.currentQNum = 27;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile27;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile28_Click(object sender, EventArgs e)
        {
            this.currentQNum = 28;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile28;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile29_Click(object sender, EventArgs e)
        {
            this.currentQNum = 29;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile29;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile30_Click(object sender, EventArgs e)
        {
            this.currentQNum = 30;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile30;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void tile31_Click(object sender, EventArgs e)
        {
            this.currentQNum = 31;
            this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile31;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            loadSelectedTile();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameBoard_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void saveQuestionButton_Click(object sender, EventArgs e)
        {
            if (CurrentQuestion == null)
                return;
            this.tiles[currentQNum].question = this.questionEntryBox.Text;
            this.tiles[currentQNum].answers[0].answer = this.answerBox0.Text;
            this.tiles[currentQNum].answers[0].correct = this.answerCorrect0.Checked;
            this.tiles[currentQNum].answers[1].answer = this.answerBox1.Text;
            this.tiles[currentQNum].answers[1].correct = this.answerCorrect1.Checked;
            this.tiles[currentQNum].answers[2].answer = this.answerBox2.Text;
            this.tiles[currentQNum].answers[2].correct = this.answerCorrect2.Checked;
            this.tiles[currentQNum].answers[3].answer = this.answerBox3.Text;
            this.tiles[currentQNum].answers[3].correct = this.answerCorrect3.Checked;
            this.CurrentQuestion.Text = this.tileNameChange.Text;
        }

        private void loadSelectedTile()
        {
            this.tileNameChange.Text = this.CurrentQuestion.Text;
            this.questionEntryBox.Text = this.tiles[currentQNum].question;
            this.answerBox0.Text = this.tiles[currentQNum].answers[0].answer;
            this.answerCorrect0.Checked = this.tiles[currentQNum].answers[0].correct;
            this.answerBox1.Text = this.tiles[currentQNum].answers[1].answer;
            this.answerCorrect1.Checked = this.tiles[currentQNum].answers[1].correct;
            this.answerBox2.Text = this.tiles[currentQNum].answers[2].answer;
            this.answerCorrect2.Checked = this.tiles[currentQNum].answers[2].correct;
            this.answerBox3.Text = this.tiles[currentQNum].answers[3].answer;
            this.answerCorrect3.Checked = this.tiles[currentQNum].answers[3].correct;
        }

        private void answerCorrect0_Checked(object sender, EventArgs e)
        {
            this.answerCorrect1.Checked = false;
            this.answerCorrect2.Checked = false;
            this.answerCorrect3.Checked = false;
        }

        private void answerCorrect1_Checked(object sender, EventArgs e)
        {
            this.answerCorrect0.Checked = false;
            this.answerCorrect2.Checked = false;
            this.answerCorrect3.Checked = false;
        }

        private void answerCorrect2_Checked(object sender, EventArgs e)
        {
            this.answerCorrect0.Checked = false;
            this.answerCorrect1.Checked = false;
            this.answerCorrect3.Checked = false;
        }

        private void answerCorrect3_Checked(object sender, EventArgs e)
        {
            this.answerCorrect0.Checked = false;
            this.answerCorrect1.Checked = false;
            this.answerCorrect2.Checked = false;
        }

        private void tileNameChange_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

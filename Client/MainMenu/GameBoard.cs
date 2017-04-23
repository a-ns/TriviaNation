using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetworkLayerInterfaces;
using GameComponents;

namespace GUILayer
{
    public partial class GameBoard : Form
    {
        IGameBoardNetwork gameNetwork;
        Game game;
        Button CurrentQuestion, CurrentNation;
        private int currentQNum, currentNationNum;
        User user;
        Tile[] tiles;
        Team[] nations;
        private int NumberOfQuestions = 32, NumberOfAnswers = 4, NumberOfNations = 4;

        public GameBoard(IGameBoardNetwork gameNetwork, Game game, User user)
        {
            this.user = user;
            this.gameNetwork = gameNetwork;
            this.game = game;
            this.tiles = this.game.tiles;
            this.nations = this.game.nations;
            InitializeComponent();
            setupGameBoard();
            this.title.Text = game.gameName;
        }

        private void setupGameBoard()
        {
            buttons[0] = tile0;
            buttons[1] = tile1;
            buttons[2] = tile2;
            buttons[3] = tile3;
            buttons[4] = tile4;
            buttons[5] = tile5;
            buttons[6] = tile6;
            buttons[7] = tile7;
            buttons[8] = tile8;
            buttons[9] = tile9;
            buttons[10] = tile10;
            buttons[11] = tile11;
            buttons[12] = tile12;
            buttons[13] = tile13;
            buttons[14] = tile14;
            buttons[15] = tile15;
            buttons[16] = tile16;
            buttons[17] = tile17;
            buttons[18] = tile18;
            buttons[19] = tile19;
            buttons[20] = tile20;
            buttons[21] = tile21;
            buttons[22] = tile22;
            buttons[23] = tile23;
            buttons[24] = tile24;
            buttons[25] = tile25;
            buttons[26] = tile26;
            buttons[27] = tile27;
            buttons[28] = tile28;
            buttons[29] = tile29;
            buttons[30] = tile30;
            buttons[31] = tile31;
            teams[0] = nation0;
            teams[1] = nation1;
            teams[2] = nation2;
            teams[3] = nation3;
            for(int i=0; i<NumberOfQuestions; i++)
            {
                buttons[i].Text = this.tiles[i].title;
            }
            for (int n = 0; n < NumberOfNations; n++)
                teams[n].Text = this.nations[n].name;

            //if (this.game.scores == null)
                //chooseTeams();
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
            loadSelectedTile();
        }

        private void tile1_Click(object sender, EventArgs e)
        {
            this.currentQNum = 1;
            loadSelectedTile();
        }

        private void tile2_Click(object sender, EventArgs e)
        {
            this.currentQNum = 2;
            loadSelectedTile();
        }

        private void tile3_Click(object sender, EventArgs e)
        {
            this.currentQNum = 3;
            loadSelectedTile();
        }

        private void tile4_Click(object sender, EventArgs e)
        {
            this.currentQNum = 4;
            loadSelectedTile();
        }

        private void tile5_Click(object sender, EventArgs e)
        {
            this.currentQNum = 5;
            loadSelectedTile();
        }

        private void tile6_Click(object sender, EventArgs e)
        {
            this.currentQNum = 6;
            loadSelectedTile();
        }

        private void tile7_Click(object sender, EventArgs e)
        {
            this.currentQNum = 7;
            loadSelectedTile();
        }

        private void tile8_Click(object sender, EventArgs e)
        {
            this.currentQNum = 8;
            loadSelectedTile();
        }

        private void tile9_Click(object sender, EventArgs e)
        {
            this.currentQNum = 9;
            loadSelectedTile();
        }

        private void tile10_Click(object sender, EventArgs e)
        {
            this.currentQNum = 10;
            loadSelectedTile();
        }

        private void tile11_Click(object sender, EventArgs e)
        {
            this.currentQNum = 11;
            loadSelectedTile();
        }

        private void tile12_Click(object sender, EventArgs e)
        {
            this.currentQNum = 12;
            loadSelectedTile();

        }

        private void tile13_Click(object sender, EventArgs e)
        {
            this.currentQNum = 13;
            loadSelectedTile();

        }

        private void tile14_Click(object sender, EventArgs e)
        {
            this.currentQNum = 14;
            loadSelectedTile();

        }

        private void tile15_Click(object sender, EventArgs e)
        {
            this.currentQNum = 15;
            loadSelectedTile();

        }

        private void tile16_Click(object sender, EventArgs e)
        {
            this.currentQNum = 16;
            loadSelectedTile();

        }

        private void tile17_Click(object sender, EventArgs e)
        {
            this.currentQNum = 17;
            loadSelectedTile();

        }

        private void tile18_Click(object sender, EventArgs e)
        {
            this.currentQNum = 18;
            loadSelectedTile();
        }

        private void tile19_Click(object sender, EventArgs e)
        {
            this.currentQNum = 19;
            loadSelectedTile();
        }

        private void tile20_Click(object sender, EventArgs e)
        {
            this.currentQNum = 20;
            loadSelectedTile();
        }

        private void tile21_Click(object sender, EventArgs e)
        {
            this.currentQNum = 21;
            loadSelectedTile();
        }

        private void tile22_Click(object sender, EventArgs e)
        {
            this.currentQNum = 22;
            loadSelectedTile();
        }

        private void tile23_Click(object sender, EventArgs e)
        {
            this.currentQNum = 23;
            loadSelectedTile();
        }

        private void tile24_Click(object sender, EventArgs e)
        {
            this.currentQNum = 24;
            loadSelectedTile();
        }

        private void tile25_Click(object sender, EventArgs e)
        {
            this.currentQNum = 25;
            loadSelectedTile();
        }

        private void tile26_Click(object sender, EventArgs e)
        {
            this.currentQNum = 26;
            loadSelectedTile();
        }

        private void tile27_Click(object sender, EventArgs e)
        {
            this.currentQNum = 27;
            loadSelectedTile();
        }

        private void tile28_Click(object sender, EventArgs e)
        {
            this.currentQNum = 28;
            loadSelectedTile();
        }

        private void tile29_Click(object sender, EventArgs e)
        {
            this.currentQNum = 29;
            loadSelectedTile();
        }

        private void tile30_Click(object sender, EventArgs e)
        {
            this.currentQNum = 30;
            loadSelectedTile();
        }

        private void tile31_Click(object sender, EventArgs e)
        {
            this.currentQNum = 31;
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

        private void loadSelectedTile()
        {
            this.questionLabel.Text = this.tiles[currentQNum].question;
            this.answer0.Text = this.tiles[currentQNum].answers[0].answer;
            this.answer1.Text = this.tiles[currentQNum].answers[1].answer;
            this.answer2.Text = this.tiles[currentQNum].answers[2].answer;
            this.answer3.Text = this.tiles[currentQNum].answers[3].answer;
        }
    }
}

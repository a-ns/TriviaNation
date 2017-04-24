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
        bool yourTurn, gameOver;
        Tile[] tiles;
        Team[] nations;
        private int NumberOfQuestions = 32, NumberOfAnswers = 4, NumberOfNations = 4, NumberOfUsersPerNation = 6;

        public GameBoard(IGameBoardNetwork gameNetwork, Game game, User user)
        {
            this.user = user;
            this.gameNetwork = gameNetwork;
            this.game = game;
            yourTurn = false;
            gameOver = false;
            this.tiles = this.game.tiles;
            this.nations = this.game.nations;
            InitializeComponent();
            setupGameBoard();
            this.title.Text = game.gameName;
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
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile0;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile1_Click(object sender, EventArgs e)
        {
            this.currentQNum = 1;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile1;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile2_Click(object sender, EventArgs e)
        {
            this.currentQNum = 2;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile2;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile3_Click(object sender, EventArgs e)
        {
            this.currentQNum = 3;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile3;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile4_Click(object sender, EventArgs e)
        {
            this.currentQNum = 4;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile4;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile5_Click(object sender, EventArgs e)
        {
            this.currentQNum = 5;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile5;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile6_Click(object sender, EventArgs e)
        {
            this.currentQNum = 6;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile6;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile7_Click(object sender, EventArgs e)
        {
            this.currentQNum = 7;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile7;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile8_Click(object sender, EventArgs e)
        {
            this.currentQNum = 8;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile8;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile9_Click(object sender, EventArgs e)
        {
            this.currentQNum = 9;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile9;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile10_Click(object sender, EventArgs e)
        {
            this.currentQNum = 10;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile10;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile11_Click(object sender, EventArgs e)
        {
            this.currentQNum = 11;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile11;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile12_Click(object sender, EventArgs e)
        {
            this.currentQNum = 12;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile12;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();

        }

        private void tile13_Click(object sender, EventArgs e)
        {
            this.currentQNum = 13;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile13;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();

        }

        private void tile14_Click(object sender, EventArgs e)
        {
            this.currentQNum = 14;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile14;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();

        }

        private void tile15_Click(object sender, EventArgs e)
        {
            this.currentQNum = 15;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile15;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();

        }

        private void tile16_Click(object sender, EventArgs e)
        {
            this.currentQNum = 16;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile16;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();

        }

        private void tile17_Click(object sender, EventArgs e)
        {
            this.currentQNum = 17;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile17;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();

        }

        private void tile18_Click(object sender, EventArgs e)
        {
            this.currentQNum = 18;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile18;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile19_Click(object sender, EventArgs e)
        {
            this.currentQNum = 19;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile19;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile20_Click(object sender, EventArgs e)
        {
            this.currentQNum = 20;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile20;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile21_Click(object sender, EventArgs e)
        {
            this.currentQNum = 21;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile21;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile22_Click(object sender, EventArgs e)
        {
            this.currentQNum = 22;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile22;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile23_Click(object sender, EventArgs e)
        {
            this.currentQNum = 23;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile23;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile24_Click(object sender, EventArgs e)
        {
            this.currentQNum = 24;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile24;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile25_Click(object sender, EventArgs e)
        {
            this.currentQNum = 25;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile25;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile26_Click(object sender, EventArgs e)
        {
            this.currentQNum = 26;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile26;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile27_Click(object sender, EventArgs e)
        {
            this.currentQNum = 27;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile27;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile28_Click(object sender, EventArgs e)
        {
            this.currentQNum = 28;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile28;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile29_Click(object sender, EventArgs e)
        {
            this.currentQNum = 29;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile29;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile30_Click(object sender, EventArgs e)
        {
            this.currentQNum = 30;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile30;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
            loadSelectedTile();
        }

        private void tile31_Click(object sender, EventArgs e)
        {
            this.currentQNum = 31;
            if (CurrentQuestion != null)
                this.CurrentQuestion.BackColor = Color.Transparent;
            this.CurrentQuestion = this.tile31;
            this.CurrentQuestion.BackColor = Color.Aquamarine;
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

        private void answer0_Click(object sender, EventArgs e)
        {
            if (this.answer0.Text == this.nation0.Text)
            {
                if (addUserToNation(nations[0]))
                {
                    MessageBox.Show("You have joined nation: " + this.nation0.Text);
                }
            }
            else if (tiles[currentQNum].answers[0].correct)
                MessageBox.Show("CORRECT!");
        }

        private void answer1_Click(object sender, EventArgs e)
        {
            if (this.answer1.Text == this.nation1.Text)
            {
                if (addUserToNation(nations[1]))
                    MessageBox.Show("You have joined nation: " + this.nation1.Text);
            }
            else if (tiles[currentQNum].answers[1].correct)
                MessageBox.Show("CORRECT!");
        }

        private void answer2_Click(object sender, EventArgs e)
        {
            if (this.answer2.Text == this.nation2.Text)
            {
                if (addUserToNation(nations[2]))
                    MessageBox.Show("You have joined nation: " + this.nation2.Text);
            }
            else if (tiles[currentQNum].answers[2].correct)
                MessageBox.Show("CORRECT!");
        }

        private void answer3_Click(object sender, EventArgs e)
        {
            if (this.answer3.Text == this.nation3.Text)
            {
                if (addUserToNation(nations[3]))
                    MessageBox.Show("You have joined nation: " + this.nation3.Text);
            }
            else if (tiles[currentQNum].answers[3].correct)
                MessageBox.Show("CORRECT!");
        }

        //Loads the selected tile to the question panel.
        private void loadSelectedTile()
        {
            this.gameNetwork.TileClick(this.tiles[currentQNum]);
            this.questionLabel.Text = this.tiles[currentQNum].question;
            this.answer0.Text = this.tiles[currentQNum].answers[0].answer;
            this.answer1.Text = this.tiles[currentQNum].answers[1].answer;
            this.answer2.Text = this.tiles[currentQNum].answers[2].answer;
            this.answer3.Text = this.tiles[currentQNum].answers[3].answer;
        }

        //Adds user to nation unless the nation is full.
        private bool addUserToNation(Team nation)
        {
            if (nation.users == null)
            {
                nation.users = new User[NumberOfUsersPerNation];
                nation.users[0] = this.user;
                disableBoard(false);
                return true;
            }
            else
            {
                int i = 0;
                while (nation.users[i] != null)
                    i++;
                if (i == NumberOfUsersPerNation)
                {
                    MessageBox.Show("Sorry this nation is full, choose another nation");
                    return false;
                }
                else
                {
                    nation.users[i] = this.user;
                    disableBoard(false);
                    return true;
                }
            }
        }

        //Turns the Question panel into a nation selection panel.
        private void chooseTeam()
        {
            disableBoard(true);
            this.questionLabel.Text = "Please select a nation from the options below: ";
            this.answer0.BackColor = this.nation0.BackColor;
            this.answer0.Text = this.nation0.Text;
            this.answer1.BackColor = this.nation1.BackColor;
            this.answer1.Text = this.nation1.Text;
            this.answer2.BackColor = this.nation2.BackColor;
            this.answer2.Text = this.nation2.Text;
            this.answer3.BackColor = this.nation3.BackColor;
            this.answer3.Text = this.nation3.Text;
        }

        //Disables the entire board for when it is not the users turn.
        private void disableBoard(bool disable)
        {
            if(!disable)
            {
                for(int a=0; a<NumberOfAnswers; a++)
                {
                    answers[a].BackColor = Color.Transparent;
                    answers[a].Text = "";
                }
            }
            for (int i = 0; i < NumberOfQuestions; i++)
                buttons[i].Enabled = !disable;
            for (int n = 0; n < NumberOfNations; n++)
                teams[n].Enabled = !disable;
        }

        //Adds all the tiles, nations, and answers buttons to their own respective arrays
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
            answers[0] = answer0;
            answers[1] = answer1;
            answers[2] = answer2;
            answers[3] = answer3;

            for (int i = 0; i < NumberOfQuestions; i++)
            {
                buttons[i].Text = this.tiles[i].title;
            }
            for (int n = 0; n < NumberOfNations; n++)
                teams[n].Text = this.nations[n].name;
            Console.WriteLine(this.game.scores);
            try
            {
                Console.WriteLine(this.game.scores[0]);

            }
            catch(IndexOutOfRangeException)
            { 
                Console.WriteLine("Choosing Teams");
                chooseTeam();
            }
        }
    }
}

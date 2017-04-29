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
        Button CurrentQuestion;
        private int currentQNum, myNationNum, TURN;
        User user;
        bool myTurn;
        Tile[] tiles;
        Tile[] lostTiles;
        Team[] nations;
        private int NumberOfQuestions = 32, NumberOfAnswers = 4, NumberOfNations = 4, NumberOfUsersPerNation = 1;
        

        public GameBoard(IGameBoardNetwork gameNetwork, Game game, User user)
        {
            this.user = user;
            this.gameNetwork = gameNetwork;
            InitializeCommunication();
            this.game = game;
            myTurn = false;
            TURN = 0;
            this.lostTiles = new Tile[NumberOfQuestions];
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
            this.CurrentQuestion = this.tile0;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile1_Click(object sender, EventArgs e)
        {
            this.currentQNum = 1;
            this.CurrentQuestion = this.tile1;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile2_Click(object sender, EventArgs e)
        {
            this.currentQNum = 2;
            this.CurrentQuestion = this.tile2;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile3_Click(object sender, EventArgs e)
        {
            this.currentQNum = 3;
            this.CurrentQuestion = this.tile3;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile4_Click(object sender, EventArgs e)
        {
            this.currentQNum = 4;
            this.CurrentQuestion = this.tile4;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile5_Click(object sender, EventArgs e)
        {
            this.currentQNum = 5;
            this.CurrentQuestion = this.tile5;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile6_Click(object sender, EventArgs e)
        {
            this.currentQNum = 6;
            this.CurrentQuestion = this.tile6;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile7_Click(object sender, EventArgs e)
        {
            this.currentQNum = 7;
            this.CurrentQuestion = this.tile7;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile8_Click(object sender, EventArgs e)
        {
            this.currentQNum = 8;
            this.CurrentQuestion = this.tile8;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile9_Click(object sender, EventArgs e)
        {
            this.currentQNum = 9;
            this.CurrentQuestion = this.tile9;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile10_Click(object sender, EventArgs e)
        {
            this.currentQNum = 10;
            this.CurrentQuestion = this.tile10;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile11_Click(object sender, EventArgs e)
        {
            this.currentQNum = 11;
            this.CurrentQuestion = this.tile11;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile12_Click(object sender, EventArgs e)
        {
            this.currentQNum = 12;
            this.CurrentQuestion = this.tile12;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();

        }

        private void tile13_Click(object sender, EventArgs e)
        {
            this.currentQNum = 13;
            this.CurrentQuestion = this.tile13;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();

        }

        private void tile14_Click(object sender, EventArgs e)
        {
            this.currentQNum = 14;
            this.CurrentQuestion = this.tile14;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();

        }

        private void tile15_Click(object sender, EventArgs e)
        {
            this.currentQNum = 15;
            this.CurrentQuestion = this.tile15;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();

        }

        private void tile16_Click(object sender, EventArgs e)
        {
            this.currentQNum = 16;
            this.CurrentQuestion = this.tile16;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();

        }

        private void tile17_Click(object sender, EventArgs e)
        {
            this.currentQNum = 17;
            this.CurrentQuestion = this.tile17;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();

        }

        private void tile18_Click(object sender, EventArgs e)
        {
            this.currentQNum = 18;
            this.CurrentQuestion = this.tile18;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile19_Click(object sender, EventArgs e)
        {
            this.currentQNum = 19;
            this.CurrentQuestion = this.tile19;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile20_Click(object sender, EventArgs e)
        {
            this.currentQNum = 20;
            this.CurrentQuestion = this.tile20;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile21_Click(object sender, EventArgs e)
        {
            this.currentQNum = 21;
            this.CurrentQuestion = this.tile21;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile22_Click(object sender, EventArgs e)
        {
            this.currentQNum = 22;
            this.CurrentQuestion = this.tile22;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile23_Click(object sender, EventArgs e)
        {
            this.currentQNum = 23;
            this.CurrentQuestion = this.tile23;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile24_Click(object sender, EventArgs e)
        {
            this.currentQNum = 24;
            this.CurrentQuestion = this.tile24;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile25_Click(object sender, EventArgs e)
        {
            this.currentQNum = 25;
            this.CurrentQuestion = this.tile25;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile26_Click(object sender, EventArgs e)
        {
            this.currentQNum = 26;
            this.CurrentQuestion = this.tile26;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile27_Click(object sender, EventArgs e)
        {
            this.currentQNum = 27;
            this.CurrentQuestion = this.tile27;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile28_Click(object sender, EventArgs e)
        {
            this.currentQNum = 28;
            this.CurrentQuestion = this.tile28;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile29_Click(object sender, EventArgs e)
        {
            this.currentQNum = 29;
            this.CurrentQuestion = this.tile29;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile30_Click(object sender, EventArgs e)
        {
            this.currentQNum = 30;
            this.CurrentQuestion = this.tile30;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void tile31_Click(object sender, EventArgs e)
        {
            this.currentQNum = 31;
            this.CurrentQuestion = this.tile31;
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.gameNetwork.TileClick(tiles[currentQNum]);
            disableBoard(false);
            loadSelectedTile();
        }

        private void GameBoard_Load(object sender, EventArgs e)
        {

        }

        private void answer0_Click(object sender, EventArgs e)
        {
            if (this.answer0.Text == this.nation0.Text)
            {
                if (addUserToNation(nations[0]))
                {
                    myTurn = true;
                    myNationNum = 0;
                    teamScores[myNationNum].BackColor = teams[myNationNum].BackColor;
                    disableAnswers(true);
                    this.gameNetwork.chooseTeam(nations[0]);
                    startGame();
                    MessageBox.Show("You have joined nation: " + this.nation0.Text);
                }
            }
            else if (tiles[currentQNum].answers[0].correct)
            {
                myTurn = false;
                addTileToNation(tiles[currentQNum]);
                Team temp = nations[myNationNum];
                temp.score = nations[myNationNum].score + 1;
                this.gameNetwork.scoreUpdate(temp);
                disableAnswers(true);
                changeTurn();
                CurrentQuestion.BackColor = teams[myNationNum].BackColor;
                MessageBox.Show("CORRECT!");
            }
            else if(!tiles[currentQNum].answers[0].correct)
            {
                myTurn = false;
                addDisabledTile(tiles[currentQNum]);
                this.gameNetwork.scoreUpdate(nations[myNationNum]);
                disableAnswers(true);
                CurrentQuestion.BackColor = Color.Black;
                changeTurn();
            }
        }

        private void answer1_Click(object sender, EventArgs e)
        {
            if (this.answer1.Text == this.nation1.Text)
            {
                if (addUserToNation(nations[1]))
                {
                    myNationNum = 1;
                    teamScores[myNationNum].BackColor = teams[myNationNum].BackColor;
                    disableAnswers(true);
                    this.gameNetwork.chooseTeam(nations[1]);
                    startGame();
                    MessageBox.Show("You have joined nation: " + this.nation1.Text);
                }
            }
            else if (tiles[currentQNum].answers[1].correct)
            {
                myTurn = false;
                addTileToNation(tiles[currentQNum]);
                Team temp = nations[myNationNum];
                temp.score = nations[myNationNum].score + 1;
                this.gameNetwork.scoreUpdate(temp);
                disableAnswers(true);
                CurrentQuestion.BackColor = teams[myNationNum].BackColor;
                changeTurn();
                MessageBox.Show("CORRECT!");
            }
            else if (!tiles[currentQNum].answers[1].correct)
            {
                myTurn = false;
                addDisabledTile(tiles[currentQNum]);
                this.gameNetwork.scoreUpdate(nations[myNationNum]);
                disableAnswers(true);
                CurrentQuestion.BackColor = Color.Black;
                changeTurn();
            }
        }

        private void answer2_Click(object sender, EventArgs e)
        {
            if (this.answer2.Text == this.nation2.Text)
            {
                if (addUserToNation(nations[2]))
                {
                    myNationNum = 2;
                    teamScores[myNationNum].BackColor = teams[myNationNum].BackColor;
                    disableAnswers(true);
                    this.gameNetwork.chooseTeam(nations[2]);
                    startGame();
                    MessageBox.Show("You have joined nation: " + this.nation2.Text);
                }
            }
            else if (tiles[currentQNum].answers[2].correct)
            {
                myTurn = false;
                addTileToNation(tiles[currentQNum]);
                Team temp = nations[myNationNum];
                temp.score = nations[myNationNum].score + 1;
                this.gameNetwork.scoreUpdate(temp);
                disableAnswers(true);
                CurrentQuestion.BackColor = teams[myNationNum].BackColor;
                changeTurn();
                MessageBox.Show("CORRECT!");
            }
            else if (!tiles[currentQNum].answers[2].correct)
            {
                myTurn = false;
                addDisabledTile(tiles[currentQNum]);
                this.gameNetwork.scoreUpdate(nations[myNationNum]);
                disableAnswers(true);
                CurrentQuestion.BackColor = Color.Black;
                changeTurn();
            }
        }

        private void answer3_Click(object sender, EventArgs e)
        {
            if (this.answer3.Text == this.nation3.Text)
            {
                if (addUserToNation(nations[3]))
                {
                    myNationNum = 3;
                    teamScores[myNationNum].BackColor = teams[myNationNum].BackColor;
                    disableAnswers(true);
                    this.gameNetwork.chooseTeam(nations[3]);
                    startGame();
                    MessageBox.Show("You have joined nation: " + this.nation3.Text);
                }
            }
            else if (tiles[currentQNum].answers[3].correct)
            {
                myTurn = false;
                addTileToNation(tiles[currentQNum]);
                Team temp = nations[myNationNum];
                temp.score = nations[myNationNum].score + 1;
                this.gameNetwork.scoreUpdate(temp);
                disableAnswers(true);
                CurrentQuestion.BackColor = teams[myNationNum].BackColor;
                changeTurn();
                MessageBox.Show("CORRECT!");
            }
            else if (!tiles[currentQNum].answers[3].correct)
            {
                myTurn = false;
                addDisabledTile(tiles[currentQNum]);
                this.gameNetwork.scoreUpdate(nations[myNationNum]);
                disableAnswers(true);
                CurrentQuestion.BackColor = Color.Black;
                changeTurn();
            }
        }

        //Loads the currently selected tile to the question panel.
        private void loadSelectedTile()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(loadSelectedTile));
                return;
            }
            if (myTurn)
                disableAnswers(false);
            CurrentQuestion = buttons[currentQNum];
            buttons[currentQNum].BackColor = Color.Aquamarine;
            this.questionTitle.Text = buttons[currentQNum].Text;
            this.questionLabel.Text = this.tiles[currentQNum].question;
            this.answer0.Text = this.tiles[currentQNum].answers[0].answer;
            this.answer1.Text = this.tiles[currentQNum].answers[1].answer;
            this.answer2.Text = this.tiles[currentQNum].answers[2].answer;
            this.answer3.Text = this.tiles[currentQNum].answers[3].answer;
        }

        //Adds user to nation selected unless the nation is full.
        private bool addUserToNation(Team nation)
        {
            if (nation.users == null)
            {
                nation.users = new User[NumberOfUsersPerNation];
                nation.users[0] = this.user;
                nation.tiles = new Tile[NumberOfQuestions / NumberOfNations];
                return true;
            }
            else
            {
                int i = 0;
                while (i<NumberOfUsersPerNation)
                    if (nation.users[i] != null)
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

        //Adds the passed tile to the disabled list (used for when a user gets a question wrong)
        private void addDisabledTile(Tile disabledTile)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Tile>(addDisabledTile), disabledTile);
                return;
            }
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                if (lostTiles[i] == null)
                {
                    lostTiles[i] = disabledTile;
                    break;
                }
            }
        }

        //This adds the passed tile to the nations claimed territory to be passed and marked on other users boards.
        private void addTileToNation(Tile tile)
        {
            for (int i=0; i < nations[myNationNum].score+1; i++)
                if (nations[myNationNum].tiles[i] == null)
                    nations[myNationNum].tiles[i] = tile;
        }

        //Turns the Question panel into a nation selection panel.
        private void chooseTeam()
        {
            disableBoard(false);
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

        //Disables or enables the entire board for when it is and is not the users turn. (also used when reloading the board after an event)
        private void disableBoard(bool disable)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<bool>(disableBoard), disable);
                return;
            }
            if (disable)
            {
                for (int a = 0; a < NumberOfAnswers; a++)
                {
                    answers[a].BackColor = Color.Transparent;
                    answers[a].Text = " ";
                }
            }
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                if (buttons[i].BackColor == Color.Black)
                    buttons[i].Enabled = false;
                else
                    buttons[i].Enabled = disable;
            }
            for (int n = 0; n < NumberOfNations; n++)
            {
                teamScores[n].Text = teams[n].Text + ": " + nations[n].score;
                teams[n].Enabled = disable;
            }
            
            markNationTiles();
            markDisabledTiles();
        }

        //Goes through and marks all of the tiles that each nation has claimed throughout the game up to this point.
        private void markNationTiles()
        {
            for (int n = 0; n < NumberOfNations; n++)
                if (nations[n].tiles != null)
                {
                    for (int i = 0; i < nations[n].tiles.Length; i++)
                        if (nations[n].tiles[i] != null)
                        {
                            buttons[nations[n].tiles[i].questionNum].Enabled = false;
                            buttons[nations[n].tiles[i].questionNum].BackColor = teams[n].BackColor;
                        }
                }
                else break;
                
        }

        //Goes through and marks all of the tiles that have been selected and marked as lost
        private void markDisabledTiles()
        {
            for (int i = 0; i < NumberOfQuestions; i++)
                if (lostTiles[i] != null)
                {
                    buttons[lostTiles[i].questionNum].BackColor = Color.Black;
                    buttons[lostTiles[i].questionNum].Enabled = false;
                }
        }

        //Disables or enables use of answer buttons
        public void disableAnswers(bool active)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<bool>(disableAnswers), active);
                return;
            }
            for (int i = 0; i < NumberOfAnswers; i++)
                answers[i].Enabled = !active;
        }

        //Checks if all nations have a user and either returns or broadcasts to all clients to start the game
        public void startGame()
        {
            bool start = false;
            for (int i = 0; i < NumberOfNations; i++)
            {
                if (nations[i].users != null)
                {
                    if (i == NumberOfNations - 1)
                        start = true;
                }
                else break;
            }
            if (start)
            {
                disableBoard(myTurn);
                this.gameNetwork.beginGame();
            }
        }

        /*
         * Adds all the tiles, nations, and answers buttons to their own respective arrays, adds correct information to each
         * corresponding tile and nation and starts the choosing team process.
        */
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
            teamScores[0] = nation0ScoreLabel;
            teamScores[1] = nation1ScoreLabel;
            teamScores[2] = nation2ScoreLabel;
            teamScores[3] = nation3ScoreLabel;

            for (int i = 0; i < NumberOfQuestions; i++)
                buttons[i].Text = this.tiles[i].title;

            for (int n = 0; n < NumberOfNations; n++)
            {
                teams[n].Text = this.nations[n].name;
                teamScores[n].Text = this.nations[n].name + ": ";
            }
            for (int s = 0; s < NumberOfNations; s++)
                teamScores[s].Text += nations[s].score;

            chooseTeam();
        }

        //Signals all clients who's turn it is
        private void changeTurn()
        {
            if (myNationNum == NumberOfNations - 1)
                this.gameNetwork.yourTurn(nations[0]);
            else
                this.gameNetwork.yourTurn(nations[myNationNum+1]);
        }
        
        //Defines the network layer communication for gameplay
        public void InitializeCommunication()
        {
            this.gameNetwork.gameBoardSetupSocket(JoinedTeamCallback, StartGameCallback, TileClickCallback, YourTurnCallback, ScoreUpdateCallback);
        }

        //This callback is executed when the network layer recieves a score update from the server
        private void ScoreUpdateCallback(Team updatedScore)
        {
            for(int i=0; i<NumberOfNations; i++)
            {
                if (nations[i].name == updatedScore.name)
                {
                    if (updatedScore.score == nations[i].score)
                    {
                        nations[i] = updatedScore;
                        if(i != myNationNum)
                            addDisabledTile(tiles[currentQNum]);
                    }
                    else
                        nations[i] = updatedScore;
                }
            }
            disableBoard(myTurn);
        }

        //This callback executes when the network layer receives a new turn signal from the server
        private void YourTurnCallback(Team thisTeamsTurn)
        {
            TURN++;
            if (TURN == 32)
                whoWins();

            Console.WriteLine("Turn Callback");
            if (nations[myNationNum].name == thisTeamsTurn.name)
                myTurn = true;

            disableBoard(myTurn);
        }

        //This callback executes when the network layer receives a tile selection from the server.
        private void TileClickCallback(Tile tileClicked)
        {
            this.currentQNum = tileClicked.questionNum;
            this.CurrentQuestion = buttons[currentQNum];
            loadSelectedTile();
        }

        //This callback executes when the network layer receives a signal to start the game.
        private void StartGameCallback(bool result)
        {
            disableBoard(myTurn);
        }

        //This callback executes when the network layer receives a new join signal from the server
        private void JoinedTeamCallback(Team teamTaken)
        {
            for (int i=0; i<NumberOfNations; i++)
                if(teamTaken.name == nations[i].name)
                    nations[i] = teamTaken;
        }

        //This method determines who won or if there was a tie and calls GameOver(result)
        private void whoWins()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(whoWins));
                return;
            }
            Team winner = nations[0], temp=null;
            for(int i=0; i<NumberOfNations-1; i++)
            {
                if (winner.score < nations[i + 1].score)
                {
                    winner = nations[i + 1];
                    temp = null;
                }
                else if (winner.score == nations[i + 1].score)
                    temp = nations[i + 1];
            }
            if (winner != null && temp != null)
                GameOver(null);
            else
                GameOver(winner);
        }

        //This method disables the board and informs the user of a winner or a tie
        private void GameOver(Team winner)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Team>(GameOver), winner);
                return;
            }
            disableBoard(false);
            disableAnswers(true);
            if(winner==null)
                MessageBox.Show("We have a Tie!");
            else
                MessageBox.Show(winner.name + " Wins!");
        }
    }
}

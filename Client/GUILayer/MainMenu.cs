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
    public partial class MainMenu : Form
    {
        private INetwork endpoint;
        private IMainMenuNetwork mainMenu;
        private IGameBoardNetwork gameNetwork;
        private User currentUser;
        

        public MainMenu(INetwork endpoint, IMainMenuNetwork mainMenu, IGameBoardNetwork gameNetwork)
        {
            this.endpoint = endpoint;
            this.mainMenu = mainMenu;
            this.gameNetwork = gameNetwork;
            InitializeComponent();
            this.mainMenu.MainMenuSetupSocket();
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            this.CreateMatch.Click += new System.EventHandler(this.CreateMatch_Click);
            this.CreateMatch.Visible = false;
            this.loadGameButton.Visible = false;
            this.loadGameBox.Visible = false;
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            String nickname = this.Nickname.Text;
            String password = this.Password.Text;
            Console.WriteLine("Signing in: " + nickname + " " + password);
            if (this.mainMenu.MainMenuSignIn(nickname, password))
            {
                currentUser = new User();
                currentUser.username = nickname;
                MessageBox.Show("Login Success");
                this.SignUp.Visible = false;
                this.SignIn.Visible = false;
                this.loadGameButton.Visible = true;
                this.loadGameBox.Visible = true;
                this.CreateMatch.Visible = true;
            }
            else
            {
                currentUser = null;
                this.CreateMatch.Visible = false;
                this.loadGameButton.Visible = false;
                this.SignUp.Visible = true;
                this.loadGameBox.Visible = false;
                MessageBox.Show("Login Failed, try again");
            }
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            String nickname = this.Nickname.Text;
            String password = this.Password.Text;
            Console.WriteLine("Signing up: " + nickname + " " + password);
            if (this.mainMenu.MainMenuSignUp(nickname, password))
            {
                currentUser = new User();
                currentUser.username = nickname;
                this.SignUp.Visible = false;
                this.SignIn.Visible = false;
                this.loadGameButton.Visible = true;
                this.loadGameBox.Visible = true;
                this.CreateMatch.Visible = true;
                MessageBox.Show("signup successful for " + nickname);
            }
            else
            {
                currentUser = null;
                this.CreateMatch.Visible = false;
                this.loadGameButton.Visible = false;
                this.SignUp.Visible = true;
                this.loadGameBox.Visible = false;
                MessageBox.Show("signup failed for " + nickname);
            }
        }

        private void CreateMatch_Click(object sender, EventArgs e)
        {
            String nickname = this.Nickname.Text;
            String password = this.Password.Text;
            Console.WriteLine("Creating match: " + nickname + " " + password);
            EditGameBoard editGame = new EditGameBoard(this.gameNetwork);
            editGame.Show();
        }

        private void loadGameButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Loading game...");
            string gameName = this.loadGameBox.Text;
            this.gameNetwork.editGameBoardSetupSocket();
            Game loadedGame = this.gameNetwork.loadGame(gameName);
            if (loadedGame == null)
            {
                MessageBox.Show("Sorry no game found for: " + gameName);
            }
            else
            {
                GameBoard game = new GameBoard(this.gameNetwork, loadedGame, currentUser);
                game.Show();
            }
        }
    }
}

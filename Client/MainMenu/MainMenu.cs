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
namespace MainMenu
{
    public partial class MainMenu : Form
    {
        private Network endpoint = Network.Instance;

        public MainMenu()
        {
            InitializeComponent();
            this.endpoint.SetEndPointLocation("http://localhost:3000");
            this.endpoint.SetupSocket(NetworkMessageBoxCallback);
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            this.CreateMatch.Click += new System.EventHandler(this.CreateMatch_Click);
            
            
        }
        private void NetworkMessageBoxCallback(String eventType, String success)
        {
            MessageBox.Show( eventType + " "+ success);
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
            this.endpoint.signin(nickname, password);
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            String nickname = this.Nickname.Text;
            String password = this.Password.Text;
            Console.WriteLine("Signing up: " + nickname + " " + password);
            this.endpoint.signup(nickname, password);
        }

        private void CreateMatch_Click(object sender, EventArgs e)
        {
            String nickname = this.Nickname.Text;
            String password = this.Password.Text;
            Console.WriteLine("Creating match: " + nickname + " " + password);
        }
    }
}

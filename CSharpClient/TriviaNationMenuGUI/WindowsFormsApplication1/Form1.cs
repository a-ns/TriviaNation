using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TriviaNationMenu : Form
    {


        public TriviaNationMenu()
        {
            InitializeComponent();
			this.SignIn.Click += new System.EventHandler(this.SignIn_Click);

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
			String username = this.Nickname.Text;
			String password = this.Password.Text;
			Console.WriteLine(username + " " + password);
			MessageBox.Show("Sign in successful");
		}


    }
}

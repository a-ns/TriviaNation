namespace MainMenu
{
    partial class MainMenu
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
            this.CreateMatch = new System.Windows.Forms.Button();
            this.Nickname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SignIn = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateMatch
            // 
            this.CreateMatch.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMatch.Location = new System.Drawing.Point(24, 246);
            this.CreateMatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateMatch.Name = "CreateMatch";
            this.CreateMatch.Size = new System.Drawing.Size(305, 76);
            this.CreateMatch.TabIndex = 0;
            this.CreateMatch.Text = "Create Session";
            this.CreateMatch.UseVisualStyleBackColor = true;
            // 
            // Nickname
            // 
            this.Nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nickname.Location = new System.Drawing.Point(24, 122);
            this.Nickname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nickname.Name = "Nickname";
            this.Nickname.Size = new System.Drawing.Size(304, 37);
            this.Nickname.TabIndex = 1;
            this.Nickname.Text = "Enter Nickname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 92);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to\r\nTrivia Nation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SignIn
            // 
            this.SignIn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.Location = new System.Drawing.Point(24, 414);
            this.SignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(305, 76);
            this.SignIn.TabIndex = 3;
            this.SignIn.Text = "Sign In To Match";
            this.SignIn.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            this.SignUp.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.Location = new System.Drawing.Point(24, 330);
            this.SignUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(305, 76);
            this.SignUp.TabIndex = 4;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = true;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(24, 183);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(304, 37);
            this.Password.TabIndex = 5;
            this.Password.Text = "Enter Password";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 519);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nickname);
            this.Controls.Add(this.CreateMatch);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainMenu";
            this.Text = "Trivia Nation Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateMatch;
        private System.Windows.Forms.TextBox Nickname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.TextBox Password;

    }
}


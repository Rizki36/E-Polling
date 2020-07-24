using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using MetroFramework.Forms;
using MetroFramework;
using System.Threading;

namespace hopeproject
{
    public partial class frmLogin : Form
    {
        private string admin;
        private string passAdmin;
        private string user;
        private string passUser;
        List<string> userPass = new List<string>();
        public frmLogin()
        {
            InitializeComponent();
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(@"pass.txt");
            while ((line = file.ReadLine()) != null)
            {
                userPass.Add(line); 
                counter++;
            }
            file.Close();
            admin = userPass[1];
            passAdmin = userPass[3];
            user = userPass[5];
            passUser = userPass[7];
        }
        
        private void openFrmAdmin()
        {
            Application.Run(new frmAdmin2());
        }

        private void openFrmUser()
        {
            Application.Run(new frmUser2());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            btnAdmin.Enabled = true;
            btnUser.Enabled = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            btnUser.Enabled = true;
            btnAdmin.Enabled = false;
        }
        
        private void frmLogin_Load(object sender, EventArgs e)
        {
            tbPassword.isPassword = true;
        }

        int counter = 0;
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if(counter == 5)
            {
                timer1.Enabled = true;
                btnLogin.Enabled = false;
            }
            else
            {
                //login admin
                if (btnAdmin.Enabled == false)
                {
                    if (tbUser.Text == admin && tbPassword.Text == passAdmin)
                    {
                        Form admin = new frmAdmin2();
                        admin.Owner = this;
                        admin.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("User or Password is not corect");
                        counter += 1;
                    }
                    
                }

                //login user
                if (btnUser.Enabled == false)
                {
                    if (tbUser.Text == user && tbPassword.Text == passUser)
                    {
                        Form user = new frmUser2();
                        user.Owner = this;
                        user.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("User or Password is not corect");
                        counter += 1;
                    }
                }
               
            }
        }
        
        private void tbUser_Enter(object sender, EventArgs e)
        {
            tbUser.Text = "";
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            tbPassword.Text = "";
        }

        private void tbUser_Leave(object sender, EventArgs e)
        {
            if (tbUser.Text == "")
                tbUser.Text = "User";
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
                tbPassword.Text = "Password";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgPassword_Click(object sender, EventArgs e)
        {
            tbPassword.isPassword = !tbPassword.isPassword;
        }
        int countTime = 30;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = string.Format("Try again in {0} seconds.",countTime);
            countTime -= 1;
            if(countTime <= 0)
            {
                lblTime.Text = "";
                timer1.Enabled = false;
                countTime = 30;
                counter = 0;
                btnLogin.Enabled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vaulty.Database.Models;

namespace Vaulty
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (!username.Equals("") && !password.Equals(""))
            {
                User.Setup();
                List<Dictionary<string, object>> coincidences = User.Where("username", username).Get();
                if (coincidences.Count == 1)
                {
                    Dictionary<string, object> user = coincidences[0];
                    Console.WriteLine("Name: " + user["name"]);
                    Console.WriteLine("Username: " + user["username"]);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled", "Fields Error");
            }
        }

        private void btnResetPwd_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

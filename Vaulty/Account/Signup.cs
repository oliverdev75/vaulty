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

namespace Vaulty.Account
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void btnSignupSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confPassword = txtConfPassword.Text;

            if (!username.Equals(""))
            {
                if (password.Equals(confPassword))
                {
                    User.Setup();
                    List<Dictionary<string, object>> coincidences = User.Where("username", username).Get();
                    if (coincidences.Count == 0)
                    {
                        User creation = new User(name, username, password, "default", "es");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username already exists, choose another.", "Fields Error");
                    }
                }
                else
                {
                    MessageBox.Show("Password and its confirmation must coincide.", "Fields Error");
                }
            }
            else
            {
                MessageBox.Show("Username cannot be empty.", "Fields Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

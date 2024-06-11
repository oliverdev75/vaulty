using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vaulty.Account;

namespace Vaulty
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnDBSettings_Click(object sender, EventArgs e)
        {
            DBSettings dbSettings = new DBSettings();
            dbSettings.Show();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            IdentitiesPanel panel = new IdentitiesPanel();
            panel.Show();
        }
    }
}

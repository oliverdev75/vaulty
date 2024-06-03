using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vaulty.Database;
using Vaulty.Exceptions;

namespace Vaulty
{
    public partial class DBSettings : Form
    {
        public DBSettings()
        {
            InitializeComponent();
        }

        private void DBSettings_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> settings = Server.GetConfig();
            this.txtHostField.Text = settings["host"];
            this.txtPortField.Text = settings["port"];
            this.txtUsernameField.Text = settings["username"];
            this.txtPasswordField.Text = settings["password"];
            this.txtDBField.Text = settings["db"];
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Control.ControlCollection formChilds = this.Controls;
            List<TextBox> txtFields = new List<TextBox>();
            bool save = true;
            foreach (Object child in formChilds)
            {
                if (child.GetType() == typeof(TextBox))
                { 
                    txtFields.Add((TextBox) child);
                }
            }

            foreach (TextBox field in txtFields)
            {
                if (field.Text.Equals("") && !field.Tag.Equals("portField"))
                {
                    save = false;
                    lblTestResult.ForeColor = Color.Red;
                    lblTestResult.Text = "ERROR: Except of port all fields must be filled to save.";
                }
            }

            if (save)
            {
                if (txtPortField.Equals(""))
                {
                    this.txtPortField.Text = "3306";
                }
                Server.SetConfig(
                    this.txtHostField.Text,
                    this.txtPortField.Text,
                    this.txtUsernameField.Text,
                    this.txtPasswordField.Text,
                    this.txtDBField.Text
                );
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTestConn_Click(object sender, EventArgs e)
        {
            try
            {
                Server tmpSrv = new Server();
                tmpSrv.Test();
                tmpSrv.CloseConn();
                this.lblTestResult.Text = "OK: connection succesful.";
            }
            catch (DBConnException)
            {
                this.lblTestResult.Text = "ERROR: connection not successful.";
            }
        }

        private void BtnRestoreDefaults_Click(object sender, EventArgs e)
        {
            this.txtHostField.Text = "localhost";
            this.txtPortField.Text = "3306";
            this.txtUsernameField.Text = "vaulty";
            this.txtPasswordField.Text = "vaulty";
            this.txtDBField.Text = "vaulty";
        }
    }
}

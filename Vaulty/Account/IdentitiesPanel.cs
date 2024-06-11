using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vaulty.Database.Models;
using Vaulty.Identities

namespace Vaulty.Account
{
    public partial class IdentitiesPanel : Form
    {
        public IdentitiesPanel()
        {
            InitializeComponent();
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            Session session = Session.Get();
            if (session != null)
            {
                Identity.Setup();
                List<Dictionary<string, object>> identities = Identity.Where("user_id", Session.Get().name).Get();
                foreach (Dictionary<string, object> identity in identities)
                {
                    lbUserIdentities.Items.Add(identity["name"]);
                }
            }
            else
            {
                MessageBox.Show("User must log in to access its identities.", "Session Error");
                this.Close();
            }
        }

        private void btnCreateIdentity_Click(object sender, EventArgs e)
        {
            Identities.Create 
        }
    }
}

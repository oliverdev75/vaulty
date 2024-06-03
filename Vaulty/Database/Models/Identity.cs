using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using Mysqlx.Crud;

namespace Vaulty.Database.Models
{
    internal class Identity : Model
    {
        internal override string Table { get; set; } = "identities";
        internal override Dictionary<string, Object> Fields { get; set; } = new Dictionary<string, Object>();

        string title;
        string username;
        string password;
        string website;
        string note;
        Group group;
        
        internal Identity(
            string title = null,
            string username = null,
            string password = null,
            string website = null,
            string note = null,
            bool save = true
            )
        {
            if (
                title != null &&
                username != null &&
                password != null &&
                website != null &&
                note != null &&
                save
                )
            {
                Fields["title"] = title;
                Fields["username"] = username;
                Fields["password"] = password;
                Fields["website"] = website;
                Fields["note"] = note;
                Insert();
            }
        }

        internal void Save()
        {
            Fields["title"] = title;
            Fields["username"] = username;
            Fields["password"] = password;
            Fields["website"] = website;
            Fields["note"] = note;
            Insert();
        }
    }
}

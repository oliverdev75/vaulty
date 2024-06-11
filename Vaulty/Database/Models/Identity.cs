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
        internal static string table = "identities";
        internal static Dictionary<string, Object> fields = new Dictionary<string, Object>();

        string title;
        string username;
        string password;
        string website;
        string note;
        Group group;
        
        internal Identity() { }
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
                fields["title"] = title;
                fields["username"] = username;
                fields["password"] = password;
                fields["website"] = website;
                fields["note"] = note;
                Insert();
            }
        }

        internal static void Setup()
        {
            Meta.SetMeta(table, fields);
        }

        internal void Save()
        {
            fields["title"] = title;
            fields["username"] = username;
            fields["password"] = password;
            fields["website"] = website;
            fields["note"] = note;
            Insert();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace Vaulty.Database.Models
{
    internal class Identity : Model
    {
        private static string Table = "identities";
        private static Dictionary<string , Object> Fields = new Dictionary<string , Object>();

        string Title;
        string Username;
        string Password;
        string Website;
        string Note;
        Group group;
        
        Identity(
            string title = null,
            string username = null,
            string password = null,
            string website = null,
            string note = null
            )
        {
            if (
                title != null &&
                username != null &&
                password != null &&
                website != null &&
                note != null
                )
            {
                Fields["title"] = title;
                Fields["username"] = username;
                Fields["password"] = password;
                Fields["website"] = website;
                Fields["note"] = note;
                InitModel(Table , Fields);
                Insert();
            }
        }

        void Save()
        {
            Fields["title"] = Title;
            Fields["username"] = Username;
            Fields["password"] = Password;
            Fields["website"] = Website;
            Fields["note"] = Note;
            InitModel(Table, Fields);
            Insert();
        }
    }
}

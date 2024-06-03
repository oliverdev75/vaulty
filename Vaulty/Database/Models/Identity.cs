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
        internal override string _Table { get; set; } = "identities";
        internal override Dictionary<string, Object> _Fields { get; set; }

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
                _Fields["title"] = title;
                _Fields["username"] = username;
                _Fields["password"] = password;
                _Fields["website"] = website;
                _Fields["note"] = note;
                Insert();
            }
        }

        internal void Save()
        {
            _Fields["title"] = title;
            _Fields["username"] = username;
            _Fields["password"] = password;
            _Fields["website"] = website;
            _Fields["note"] = note;
            Insert();
        }
    }
}

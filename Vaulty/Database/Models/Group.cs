using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Drawing;

namespace Vaulty.Database.Models
{
    internal class Group : Model
    {
        internal static string table = "groups";
        internal static Dictionary<string , Object> fields = new Dictionary<string , Object>();

        internal string name;
        internal string icon;
        internal List<Identity> identities;
        
        internal Group() { }
        internal Group(
            string name = null,
            int icon = 0,
            bool save = true
            )
        {
            if (
                name != null &&
                icon > -1 &&
                save
                )
            {
                fields["name"] = name;
                fields["icon"] = icon;
                Insert();
            }
        }

        internal static void Setup()
        {
            Meta.table = table;
            Meta.fields = fields;
        }

        internal void Save()
        {
            fields["name"] = name;
            fields["icon"] = icon;
            Insert();
        }
    }
}

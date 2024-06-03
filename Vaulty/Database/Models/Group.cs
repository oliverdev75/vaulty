using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace Vaulty.Database.Models
{
    internal class Group : Model
    {
        internal override string _Table { get; set; } = "groups";
        internal override Dictionary<string , Object> _Fields { get; set; } = new Dictionary<string , Object>();

        internal string Name;
        internal string Icon;
        internal List<Identity> identities;
        
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
                _Fields["name"] = name;
                _Fields["icon"] = icon;
                Insert();
            }
        }

        internal void Save()
        {
            _Fields["name"] = Name;
            _Fields["icon"] = Icon;
            Insert();
        }
    }
}

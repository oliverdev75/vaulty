using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using K4os.Compression.LZ4.Streams;

namespace Vaulty.Database.Models
{
    internal class User : Model
    {
        internal static string table = "users";
        internal static Dictionary<string , Object> fields = new Dictionary<string , Object>();

        public string name;
        public string username;
        public string password;
        public string img;
        public string lang;
        public List<Identity> identities;
        
        public User() { }
        internal User(
            string name = null,
            string username = null,
            string password = null,
            string img = null,
            string lang = null,
            bool save = true
            )
        {
            if (
                name != null &&
                username != null &&
                password != null &&
                img != null &&
                lang != null &&
                save
                )
            {
                fields["name"] = name;
                fields["username"] = username;
                fields["password"] = password;
                fields["img"] = img;
                fields["lang"] = lang;
                Insert();
            }
            else
            {
                name = name;
                username = username;
                password = password;
                img = img;
                lang = lang;
            }
        }

        internal static void Setup()
        {
            Meta.SetMeta(table, fields);
        }

        public override string ToString()
        {
            return $"Name: {name}, Username: {username}";
        }

        internal void Save()
        {
            fields["name"] = name;
            fields["username"] = username;
            fields["password"] = password;
            fields["img"] = img;
            fields["lang"] = lang;
            Insert();
        }
    }
}

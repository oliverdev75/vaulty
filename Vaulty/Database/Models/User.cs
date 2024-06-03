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
        internal override string _Table { get; set; } = "users";
        internal override Dictionary<string , Object> _Fields { get; set; } = new Dictionary<string , Object>();

        internal string Name;
        internal string Username;
        internal string Password;
        internal string Img;
        internal string Lang;
        internal List<Identity> identities;
        
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
                Fields["name"] = name;
                Fields["username"] = username;
                Fields["password"] = password;
                Fields["img"] = img;
                Fields["lang"] = lang;
                Model instance = new Model();
                instance.Insert(Fields);
            }
            else
            {
                Name = name;
                Username = username;
                Password = password;
                Img = img;
                Lang = lang;
            }
        }

        internal void Save()
        {
            Fields["name"] = Name;
            Fields["username"] = Username;
            Fields["password"] = Password;
            Fields["img"] = Img;
            Fields["lang"] = Lang;
            Model instance = new Model();
            instance.Insert(Fields);
        }


        /*internal List<User> Get()
        {
            List<User> records = this.GetRecords();

            return records;
        }*/
    }
}

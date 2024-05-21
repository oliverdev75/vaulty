using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaulty.Database.Models
{
    internal class User : Model
    {
        Table = "users";
        Fields = {};

        string name;
        string username;
        string password;
        //Array<Identity> identities;

        
        User()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaulty.Account
{
    internal class Session
    {
        public static Session singleton;

        public int id;
        public string name;
        public string username;

        private Session(int id, string name, string username)
        {
            this.id = id;
            this.name = name;
            this.username = username;
        }

        public static Session Get()
        {
            return singleton;
        }

        public static Session Enable(int id, string name, string username)
        {
            if (singleton == null)
            {
                singleton = new Session(id, name, username);
            }
            return singleton;
        }
    }
}

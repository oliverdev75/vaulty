using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaulty.Database
{
    internal class Server
    {
        public struct ConnProps
        {
            public string host;
            public string port;
            public string username;
            public string password;
            public string db;
        }

        private const string CONFIG_FILE = "dbconfig.json";
        private string _ConnString;
        protected MySqlConnection _Conn;
        protected string _Query;
        protected MySqlCommand _QueryExec;
        protected MySqlDataReader _DataReader;

        protected void SetupConfig()
        {
            string configFile = File.ReadAllText(CONFIG_FILE);
            ConnProps config = JsonSerializer.Deserialize<ConnProps>(configFile);
            _ConnString = $"server={config.host},port={config.port},user={config.username}," +
                $"password={config.password},database={config.db}";
        }

        internal static void setConfig(
                string host,
                string port,
                string username,
                string password,
                string db
            )
        {

        }

        protected bool Test()
        {
            SetupConfig();
            try
            {
                _Conn = new MySqlConnection(_ConnString);
                _Conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        protected void Exec()
        {
            _QueryExec = new MySqlCommand(_Query, _Conn);
            _DataReader = _QueryExec.ExecuteReader();
        }
    }
}

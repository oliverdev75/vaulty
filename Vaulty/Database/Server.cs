using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Vaulty.Database.Models;
using Vaulty.Exceptions;

namespace Vaulty.Database
{
    internal abstract class Server
    {
        [Serializable]
        private struct ConnProps
        {
            [JsonPropertyName("host")]
            public string Host { get; set; }

            [JsonPropertyName("port")]
            public string Port { get; set; }

            [JsonPropertyName("username")]
            public string Username { get; set; }

            [JsonPropertyName("password")]
            public string Password { get; set; }

            [JsonPropertyName("db")]
            public string Db { get; set; }
        }

        private const string PATH = "C:\\Users\\ovrsc\\source\\repos\\twister91\\vaulty\\Vaulty\\bin\\Debug\\";
        private const string CONFIG_FILE = "dbconfig.json";
        private string _ConnString;
        protected MySqlConnection _Conn;
        protected abstract string _Query { get; set; }
        protected MySqlCommand _QueryExec;
        protected abstract MySqlDataReader _DataReader { get; set; }

        protected void SetupConfig()
        {
            string configFile = File.ReadAllText(CONFIG_FILE);
            ConnProps config = JsonSerializer.Deserialize<ConnProps>(configFile);
            _ConnString = $"server={config.Host},port={config.Port},user={config.Username}," +
                $"password={config.Password},database={config.Db}";
        }

        internal static void SetConfig(
                string host,
                string port,
                string username,
                string password,
                string db
            )
        {
            ConnProps connProps = new ConnProps
            {
                Host = host,
                Port = port,
                Username = username,
                Password = password,
                Db = db
            };

            string connData = JsonSerializer.Serialize(connProps);
            File.WriteAllText(CONFIG_FILE, connData);
        }

        internal static Dictionary<string, string> GetConfig()
        {
            string configFile = File.ReadAllText(PATH + CONFIG_FILE);
            ConnProps jsonConfig = JsonSerializer.Deserialize<ConnProps>(configFile);
            return new Dictionary<string, string>
            {
                { "host", jsonConfig.Host },
                { "port", jsonConfig.Port },
                { "username", jsonConfig.Username },
                { "password", jsonConfig.Password },
                { "db", jsonConfig.Db }
            };
        }

        internal void Test()
        {
            SetupConfig();
            try
            {
                _Conn = new MySqlConnection(_ConnString);
                _Conn.Open();
            }
            catch (Exception)
            {
                throw new DBConnException();
            }
        }

        internal void CloseConn()
        {
            if (_Conn != null)
            {
                _Conn.Close();
            }
        }

        protected void Exec()
        {
            _QueryExec = new MySqlCommand(_Query, _Conn);
            _DataReader = _QueryExec.ExecuteReader();
        }
    }
}

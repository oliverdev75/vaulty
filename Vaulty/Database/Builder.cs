using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaulty.Database
{
    internal class Builder
    {
        Builder SConnector = null;
        private string _ConnString;
        private MySqlConnection _Conn;
        private string _Query;
        private MySqlCommand _QueryExec;
        private MySqlDataReader _DataReader;
        private List<string> _DataFields = new List<string>();
        private Dictionary<string, Object> Data = new Dictionary<string, object>();
        private string _Table;
        private string[] Fields;

        internal Builder(string table, string qParams)
        {
            _Table = table;
            _Query = qParams + " ";
        }

        private bool Test()
        {
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

        private void Exec()
        {
            _QueryExec = new MySqlCommand(_Query, _Conn);
            _DataReader = _QueryExec.ExecuteReader();
        }

        Dictionary<string, Object> Get()
        {
            Dictionary<string, Object> data = new Dictionary<string, Object>();
            int i = 0;
            Test();

            _Query = "select * from " + _Table + _Query;

            Exec();

            while (_DataReader.Read())
            {
                Data.Add(_DataReader.GetName(i), _DataReader[i]);
                i++;
            }

            _Conn.Close();
            return data;
        }

        void Update()
        {
            Test();

            _Query = "update table " + _Table + _Query;

            Exec();

            while (_DataReader.Read()) { }
        }

        void Delete()
        {
            Test();

            _Query = "delete from " + _Table + " " + _Query;

            Exec();
            while (_DataReader.Read()) { }
        }

        Builder Sort(string field, string type = "asc")
        {
            _Query += "order by " + field + " " + type;
            return this;
        }

        Builder Where(string field, string value)
        {
            _Query += "and " + field + " = '" + value + "'";
            return this;
        }

        Builder Where(string field, string condOperator, string value)
        {
            _Query += "and " + field + " " + condOperator + " '" + value + "'";
            return this;
        }

        Builder OrWhere(string field, string value)
        {
            _Query += "or " + field + " '" + value + "'";
            return this;
        }

        Builder OrWhere(string field, string condOperator, string value)
        {
            _Query += "or " + field + " " + condOperator + " '" + value + "'";
            return this;
        }
    }
}

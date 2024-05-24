using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaulty.Database
{
    internal class Model : Server
    {

        private MySqlDataReader _DataReader;
        private List<string> _DataFields = new List<string>();
        private Dictionary<string, Object> Data = new Dictionary<string, object>();
        private string _Table;

        internal Model(string table, string qParams)
        {
            _Table = table;
            _Query = qParams + " ";
        }

        protected List<Dictionary<string, Object>> GetRecords()
        {
            List<Dictionary<string, Object>> data = new List<Dictionary<string, Object>>();
            int i = 0;
            Test();

            _Query = $"select * from {_Table} {_Query}";

            Exec();

            while (_DataReader.Read())
            {
                Dictionary<string, Object> record = new Dictionary<string, Object>();
                for (int i = 0; i < _DataReader.FieldCount; i++)
                {
                    record.Add(_DataReader.GetName(i), _DataReader[i]);
                }
                data.Add(record);
                i++;
            }

            _Conn.Close();
            return data;
        }

        void Update()
        {
            Test();

            _Query = $"update table {_Table} {_Query}";

            Exec();

            while (_DataReader.Read()) { }
        }

        void Delete()
        {
            Test();

            _Query = $"delete from {_Table} {_Query}";

            Exec();
            while (_DataReader.Read()) { }
        }

        Model Sort(string field, string type = "asc")
        {
            _Query += $" order by {field} {type}";
            return this;
        }

        Model Where(string field, string value)
        {
            _Query += $" and {field} = '{value}'";
            return this;
        }

        Model Where(string field, string condOperator, string value)
        {
            _Query += $" and {field} {condOperator} '{value}'";
            return this;
        }

        Model OrWhere(string field, string value)
        {
            _Query += $" or {field} = '{value}'";
            return this;
        }

        Model OrWhere(string field, string condOperator, string value)
        {
            _Query += $" or {field} {condOperator} '{value}'";
            return this;
        }
    }
}

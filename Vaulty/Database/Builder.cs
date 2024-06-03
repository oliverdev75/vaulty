using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vaulty.Database
{
    internal class Builder : Server
    {
        protected override string _Query { get; set; }
        protected override MySqlDataReader _DataReader { get; set; }
        private List<string> _DataFields = new List<string>();
        private string Table { get; set; }
        private Dictionary<string, Object> Fields { get; set; } = new Dictionary<string, Object>();

        internal Builder(string table, Dictionary<string, Object> fields)
        {
            Table = table;
            Fields = fields;
        }

        protected List<Dictionary<string, object>> Get(string[] fields = null)
        {
            List<Dictionary<string, object>> data = new List<Dictionary<string, object>>();
            Test();
            if (fields == null)
            {
                fields[0] = "*";
            }

            _Query = "select ";
            string[] queryParams = new string[fields.Length];

            foreach (string field in fields)
            {
                queryParams[queryParams.Length] = field;
            }
                
            _Query += $"{String.Join(",", queryParams)} from {Table} {_Query}";

            Exec();

            Dictionary<string, object> record;
            object entity;
            Type entityType;
            PropertyInfo[] entityAttribs;
            while (_DataReader.Read())
            {
                entityType = _DataReader.GetType();
                entity = Activator.CreateInstance();
                entityType = entity.GetType();
                entityAttribs = PropertyInfo.Get
                for (int i = 0; i < _DataReader.FieldCount; i++)
                {
                    record.Add(_DataReader.GetName(i), _DataReader[i]);
                }
                data.Add(record);
            }

            _Conn.Close();
            return data;
        }

        internal void Insert()
        {
            List<string> fields = new List<string>(_Fields.Keys);
            List<Object> values = new List<Object>(_Fields.Values);
            _Query = $"insert into {_Table} (";

            for (int i = 0; i < fields.Count; i++)
            {
                _Query += fields[i];
                if (i < fields.Count - 1)
                {
                    _Query += ",";
                }
            }

            _Query += ") values (";

            for (int i = 0; i < values.Count; i++)
            {
                _Query += values[i];
                if (i < values.Count - 1)
                {
                    _Query += ",";
                }
            }

            _Query += ")";
            Test();
            Exec();
        }

        internal void Update()
        {
            Test();

            _Query = $"update table {_Table} {_Query}";

            Exec();

            while (_DataReader.Read()) { }
        }

        internal void Delete()
        {
            Test();

            _Query = $"delete from {_Table} {_Query}";

            Exec();
            while (_DataReader.Read()) { }
        }

        internal Builder Sort(string field, string type = "asc")
        {
            _Query += $" order by {field} {type}";
            return this;
        }

        internal Builder Where(string field, string value)
        {
            _Query += $" and {field} = '{value}'";
            return this;
        }

        internal Builder Where(string field, string condOperator, string value)
        {
            _Query += $" and {field} {condOperator} '{value}'";
            return this;
        }

        internal Builder OrWhere(string field, string value)
        {
            _Query += $" or {field} = '{value}'";
            return this;
        }

        internal Builder OrWhere(string field, string condOperator, string value)
        {
            _Query += $" or {field} {condOperator} '{value}'";
            return this;
        }
    }
}

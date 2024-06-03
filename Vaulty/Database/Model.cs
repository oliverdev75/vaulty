﻿using Google.Protobuf;
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
    internal abstract class Model : Server
    {

        

        internal Model(string qParams = "")
        {
            _Query = qParams + " ";
        }

        protected List<Dictionary<string, Object>> GetRecords()
        {
            List<Dictionary<string, Object>> data = new List<Dictionary<string, Object>>();
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

        internal static Model PrepSort(string field, string type = "asc")
        {
            return new Model($" order by {field} {type}");
        }

        internal static Model PrepWhere(string field, string condOperator, string value)
        {
            return new Model($" and {field} {condOperator} '{value}'");
        }

        internal static Model PrepOrWhere(string field, string value)
        {
            return new Model($" or {field} = '{value}'");
        }

        internal static Model PrepOrWhere(string field, string condOperator, string value)
        {
            return new Model($" or {field} {condOperator} '{value}'");
        }

        internal Model Sort(string field, string type = "asc")
        {
            _Query += $" order by {field} {type}";
            return this;
        }

        internal Model Where(string field, string value)
        {
            _Query += $" and {field} = '{value}'";
            return this;
        }

        internal Model Where(string field, string condOperator, string value)
        {
            _Query += $" and {field} {condOperator} '{value}'";
            return this;
        }        

        internal Model OrWhere(string field, string value)
        {
            _Query += $" or {field} = '{value}'";
            return this;
        }

        internal Model OrWhere(string field, string condOperator, string value)
        {
            _Query += $" or {field} {condOperator} '{value}'";
            return this;
        }
    }
}

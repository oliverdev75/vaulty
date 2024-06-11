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
        private string Table { get; set; }
        private Dictionary<string, Object> Fields { get; set; } = new Dictionary<string, Object>();
        private List<string> strictConditions = new List<string>();
        private List<string> flexibleConditions = new List<string>();
        private List<string> backShape = new List<string>();
        private List<string> setParams = new List<string>();

        internal Builder(string table, Dictionary<string, Object> fields)
        {
            Table = table;
            Fields = fields;
        }

        public override string ToString()
        {
            Smooth();
            return _Query;
        }

        internal List<Dictionary<string, object>> Get(List<string> fields = null)
        {
            List<Dictionary<string, object>> data = new List<Dictionary<string, object>>();
            Test();
            if (fields == null)
            {
                fields = new List<string>();
                fields.Add("*");
            }


            string subject = "select";
            if (fields.Count == 1)
            {
                subject += $" {fields[0]} from {Table} {_Query}";
            } else
            {
                subject += $" {String.Join(",", fields)} from {Table} {_Query}";
            }
            Smooth(subject);
            Exec();

            //object entity;
            //PropertyInfo[] entityAttribs;
            Dictionary<string, object> row = null;
            while (_DataReader.Read())
            {
                /*entity = Activator.CreateInstance(Type.GetType("Vaulty.Database.Models.User"));
                entityAttribs = entity.GetType().GetProperties();
                i = 0;
                foreach (PropertyInfo attrib in entityAttribs)
                {
                    attrib.SetValue(entity, _DataReader[i]);
                    i++;
                }
                Console.WriteLine(entity);*/
                row = new Dictionary<string, object>();
                for (int i = 0; i < _DataReader.FieldCount; i++)
                {
                    row.Add(_DataReader.GetName(i), _DataReader[_DataReader.GetName(i)]);
                }
                data.Add(row);
            }

            _Conn.Close();
            return data;
        }

        internal void Insert()
        {
            List<string> fields = new List<string>(Fields.Keys);
            List<Object> values = new List<Object>(Fields.Values);
            _Query = $"insert into {Table} (";

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
                _Query += $"'{values[i]}'";
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
            Smooth($"update table {Table}");
            Exec();
            while (_DataReader.Read()) { }
        }

        internal void Delete()
        {
            Test();
            Smooth("delete from ");
            Exec();
            while (_DataReader.Read()) { }
        }

        internal Builder Set(string field, string value, string dataType = "string")
        {
            if (dataType.Equals("string"))
            {
                setParams.Add($"{field} = '{value}'");
            }
            else
            {
                setParams.Add($"{field} = {value}");
            }

            return this;
        }

        internal Builder OrderBy(string field, string type = "asc")
        {
            backShape.Add($" order by {field} {type}");
            return this;
        }

        internal Builder Where(string field, string value)
        {
            strictConditions.Add($"{field} = '{value}'");
            return this;
        }

        internal Builder Where(string field, string condOperator, string value)
        {
            strictConditions.Add($"{field} {condOperator} '{value}'");
            return this;
        }

        internal Builder OrWhere(string field, string value)
        {
            flexibleConditions.Add($"{field} = '{value}'");
            return this;
        }

        internal Builder OrWhere(string field, string condOperator, string value)
        {
            flexibleConditions.Add($"{field} {condOperator} '{value}'");
            return this;
        }

        private void Smooth(string subject = "")
        {
            _Query = subject;

            string ands = "";
            string ors = "";

            if (strictConditions.Count > 0)
            {
                ands = string.Join(" and ", strictConditions);
            }

            if (flexibleConditions.Count > 0)
            {
                ors = string.Join(" or ", flexibleConditions);
            }
            
            if (strictConditions.Count > 0 || flexibleConditions.Count > 0)
            {
                _Query += $" where {ands} {ors}";
            }

            if (backShape.Count > 0)
            {
                _Query += " " + string.Join("", backShape);
            }
        }
    }
}

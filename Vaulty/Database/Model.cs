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
    internal class Model
    {
        private List<string> _DataFields = new List<string>();
        private Dictionary<string, Object> Data = new Dictionary<string, object>();
        protected static string Table {  get; set; }
        protected static Dictionary<string, Object> Fields = new Dictionary<string, Object>();

        static void InitModel(string table, Dictionary<string, Object> fields)
        {
            Table = table;
            Fields = fields;
        }

        Model()
        {
            string query = "insert into " + Table + " (";
            List<string> fields = new List<string>(Fields.Keys);
            List<string> values = new List<string>(Fields.Values);
            for (int i = 0; i < Fields.Count(); i++)
            {
                query += fields[i];
                if (i < Fields.Count - 1)
                {
                    query += ",";
                }
            }

            query += ") values (";
            for (int i = 0; i < Fields.Count(); i++)
            {
                query += values[i];
                if (i < Fields.Count - 1)
                {
                    query += ",";
                }
            }
        }

        static Builder Sort(string field, string type = "asc")
        {
            return new Builder(Table, "order by " + field + " " + type);
        }

        static Builder Where(string field, string value)
        {
            return new Builder(Table, "where " + field + " = '" + value + "'");
        }

        static Builder Where(string field, string condOperator, string value)
        {
            return new Builder(Table, "where " + field + " " + condOperator + " '" + value + "'");
        }
    }
}

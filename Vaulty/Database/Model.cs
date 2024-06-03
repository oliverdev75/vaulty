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
    internal abstract class Model
    {

        internal abstract string Table { get; set; }
        internal abstract Dictionary<string, Object> Fields { get; set; }

        internal void Insert()
        {
            Builder build = new Builder(Table, Fields);
            build.Insert();
        }

        internal Builder Where(string field, string value)
        {
            Builder build = new Builder(Table, Fields);
            build.Where(field, value);
            return build;
        }

        internal Builder Where(string field, string condOperator, string value)
        {
            Builder build = new Builder(Table, Fields);
            build.OrWhere(field, condOperator, value);
            return build;
        }        

        internal Builder OrWhere(string field, string value)
        {
            Builder build = new Builder(Table, Fields);
            build.OrWhere(field, value);
            return build;
        }

        internal Builder OrWhere(string field, string condOperator, string value)
        {
            Builder build = new Builder(Table, Fields);
            build.OrWhere(field, condOperator, value);
            return build;
        }

        internal Builder OrderBy(string field, string type = "asc")
        {
            Builder build = new Builder(Table, Fields);
            build.OrderBy(field, type);
            return build;
        }
    }
}

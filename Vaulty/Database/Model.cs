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
        protected static void Insert()
        {
            Builder build = new Builder(Meta.table, Meta.fields);
            build.Insert();
        }

        internal static Builder Where(string field, string value)
        {
            Builder build = new Builder(Meta.table, Meta.fields);
            build.Where(field, value);
            return build;
        }

        internal static Builder Where(string field, string condOperator, string value)
        {
            Builder build = new Builder(Meta.table, Meta.fields);
            build.OrWhere(field, condOperator, value);
            return build;
        }        

        internal static Builder OrWhere(string field, string value)
        {
            Builder build = new Builder(Meta.table, Meta.fields);
            build.OrWhere(field, value);
            return build;
        }

        internal static Builder OrWhere(string field, string condOperator, string value)
        {
            Builder build = new Builder(Meta.table, Meta.fields);
            build.OrWhere(field, condOperator, value);
            return build;
        }

        internal static Builder OrderBy(string field, string type = "asc")
        {
            Builder build = new Builder(Meta.table, Meta.fields);
            build.OrderBy(field, type);
            return build;
        }
    }
}

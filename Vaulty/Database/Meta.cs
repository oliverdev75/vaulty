using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaulty.Database
{
    internal class Meta
    {
        internal static string table;
        internal static Dictionary<string, Object> fields;

        internal static void SetMeta(string table, Dictionary<string, Object> fields)
        {
            Meta.table = table;
            Meta.fields = fields;
        }
    }
}

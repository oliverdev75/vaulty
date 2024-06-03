using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaulty.Exceptions
{
    internal class DBConnException : Exception
    {
        internal DBConnException() 
        {
            MessageBox.Show("The database is not responding, please contact " +
                "the administrator or change the database settings",
                "Database Error");
        }
    }
}

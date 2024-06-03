using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaulty
{
    internal class Resources
    {
        internal List<Object> GetChilds(ICollection<Object> collection, Object obj)
        {
            List<Object> childs = new List<Object>();
            foreach (Object child in collection)
            {
                if (child.GetType() == obj.GetType())
                {
                    childs.Add(child);
                }
            }

            return childs;
        }
    }
}

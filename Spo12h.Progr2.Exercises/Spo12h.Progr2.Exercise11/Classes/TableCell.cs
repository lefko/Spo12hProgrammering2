using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2.Exercise11.Classes
{
    class TableCell
    {
        public string Content { get; set; }

        public TableCell(string content)
        {
            this.Content = content;
        }

        public override string ToString()
        {
            string output = string.Format("<td>{0}</td>", Content);
            return output;
        }
    }
      
}

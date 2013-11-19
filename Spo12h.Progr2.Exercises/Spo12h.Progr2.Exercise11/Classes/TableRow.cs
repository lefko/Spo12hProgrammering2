using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spo12h.Progr2.Exercise11.Classes;

namespace Spo12h.Progr2.Exercise11
{
    class TableRow
    {
        private List<TableCell> tableCells;

        public int Count
        {
            get
            {
                return tableCells.Count;
            }
        }

        public TableRow(TableCell tCell)
        {
            tableCells = new List<TableCell>();
            tableCells.Add(tCell);
        }

        public void AddCell(TableCell tCell)
        {
            tableCells.Add(tCell);
        }

        public override string ToString()
        {
            string output = "\t<tr>\n\t\t";

            foreach (TableCell tCell in tableCells)
            {
                output = string.Format("{0}{1}", output, tCell.ToString());
            }

            output = output + "\n\t</tr>\n";
            return output;
        }
    }
}

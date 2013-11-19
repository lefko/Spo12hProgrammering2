using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2.Exercise11.Classes
{
    class Table
    {
        private List<TableRow> tableRows;

        public Table(TableRow tRow)
        {
            tableRows = new List<TableRow>();
            tableRows.Add(tRow);
        }

        public Table()
        {
            tableRows = new List<TableRow>();
        }

        public void AddRow(TableRow tRow)
        {
            
            int longestRowLength = FindTheLongetRowLength();

            for (int i = 1; i < longestRowLength; i++)
            {
                TableCell cellToAdd = new TableCell("Empty Cell");
                tRow.AddCell(cellToAdd);
            }
                
            tableRows.Add(tRow);

        }

        private int FindTheLongetRowLength()
        {
            int LongestRowLength = 0;

            foreach (TableRow tableRow in tableRows)
            {
                if (tableRow.Count > LongestRowLength)
                    LongestRowLength = tableRow.Count;
            }

            return LongestRowLength;
        }

        public override string ToString()
        {
            
            string rowsToAdd = "";

            foreach (TableRow  tableRow in tableRows)
            {
                rowsToAdd = rowsToAdd + tableRow.ToString();
            }

            string output = string.Format("<table>\n{0}</table>", rowsToAdd);
            
            return output;
        }
    }
}

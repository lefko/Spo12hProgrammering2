using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spo12h.Progr2.Exercise11.Classes;

namespace Spo12h.Progr2.Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Table myTable = new Table();

            // insert my first row with 1 cell
            TableCell firstCellToAdd = new TableCell("My first cell");
            TableRow firstRowToAdd = new TableRow(firstCellToAdd);

            // add a second cell

            TableCell secondCellToAdd = new TableCell("My second cell");
            firstRowToAdd.AddCell(secondCellToAdd);

            myTable.AddRow(firstRowToAdd);

            // Add a second row. This time Empty

            TableCell firstCellTosecondRow = new TableCell("Row 2 cell 1");
            TableRow secondRowToAdd = new TableRow(firstCellTosecondRow);

            myTable.AddRow(secondRowToAdd);

            Console.WriteLine(myTable.ToString());

            Console.ReadLine();
        }
    }
}

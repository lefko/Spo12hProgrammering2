using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12h.Progr2.Sessions.Jonathan2
{
    class Receipt
    {
        private class ReceiptLine
        {

            public string Name { get; set; }
            public int Price { get; set; }
            public int Quantity { get; set; }
        }

        private string cashier;
        private List<ReceiptLine> lines; 

        public Receipt(string cashier)
        {
            this.cashier = cashier;
            this.lines = new List<ReceiptLine>();
        }
        internal void AddItem(string name, int price)
        {
            var line = new ReceiptLine();
            line.Name = name;
            line.Price = price;
            line.Quantity = 1;
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            output.AppendFormat("You where served by {0}\n", cashier);
            output.AppendLine();
            foreach (var line in lines)
            {
                output.AppendFormat("{0} x {1} @ {2}\n",
                    line.Name, line.Quantity, line.Price);
            }
            return output.ToString();
        }
    }
}

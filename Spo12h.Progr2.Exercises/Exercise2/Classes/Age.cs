using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Age
    {
        private int age ;

        public Age(int age)
        {
            if(age > 0 && age < 120)
                this.age = age;
            else
                throw new Exception("Invalid Age");
        }

        public int GetAge()
        {
            return age;
        }
    }
}

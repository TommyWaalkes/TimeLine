using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLine
{
    abstract class HistoricalEvent
    {
        protected int year;
        protected String Name;
        protected String Description;
        protected bool IsAD;

        public HistoricalEvent(int y, string n, string d, bool IsAD)
        {
            year = y;
            Name = n;
            Description = d;
            this.IsAD = IsAD;
        }

        public int GetYear()
        {
            return year;
        }

        public void PrintDetails()
        {
            if (IsAD == true)
            {
                Console.WriteLine("In Year " + year +" AD");
            }
            else
            {
                Console.WriteLine("In Year " + year + "BC");
            }
            Console.WriteLine("The " +Name +" Happened");
            Console.WriteLine(Description);
            Console.WriteLine();
        }
    }
}

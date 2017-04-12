using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLine
{
    class Program
    {
        static void Main(string[] args)
        {
            HistoricalEvent h = new FoundingOfRome();
            HistoricalEvent h1 = new Declaration();
            Battle b = new BattleOfPuns();

            TimeLine t = new TimeLine();

            t.Add(h);
            t.Add(h1);
            t.Add(b);

            t.PrintTimeLine();
          
            
        }
    }
}

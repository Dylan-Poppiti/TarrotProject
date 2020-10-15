using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TarotProject
{
    public class Spread
    {
        public string Name { get; set; }
        public int CardNumber { get; set; }

        public Spread(string n, int cn)
        {
            Name = n;
            CardNumber = cn;
        }
    }
}

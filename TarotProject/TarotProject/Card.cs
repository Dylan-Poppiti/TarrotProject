using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TarotProject
{
    public class Card
    {
        public string Name { get; set; }
        public string[] Meaning { get; set; }
        public string[] rMeaning { get; set; }

        public bool IsReversed { get; set; }

        public Card(string n, string[] m, string[] rm)
        {
            Name = n;
            Meaning = m;
            rMeaning = rm;
            IsReversed = false;
        }
    }

}

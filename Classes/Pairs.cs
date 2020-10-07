using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Pairs
    {
        public string a;
        public string b;
        public Pairs(string a, string b)
        {
            this.a = a;
            this.b = b;
        }
        public Pairs()
        {

        }
        public static bool Contains(List<Pairs> Pairs, Pairs Pair)
        {
            foreach (var pair in Pairs)
            {
                if ((pair.a == Pair.a) && (pair.b == Pair.b))
                {
                    return true;
                }
            }
            return false;
        }
       
    }
}

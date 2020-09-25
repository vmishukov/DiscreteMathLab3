using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    class Pairs
    {
        public int a;
        public int b;
        public Pairs(int a, int b)
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
        //шайтан сортировка
        public static void Sort(List<int> Set, List<Pairs> Pairs)
        {
            List<Pairs> Sorted = new List<Pairs>();
            if (Set !=null)           
            foreach (var a in Set)
            {
                List<Pairs> Midsorted = new List<Pairs>();
                foreach (var pair in Pairs)
                {
                    if (pair.a == a)
                    {
                        Midsorted.Add(new Classes.Pairs(pair.a, pair.b));
                    }

                }
                int temp;
                for (int i = 0; i < Midsorted.Count; i++)
                {
                    for (int j = 0; j < Midsorted.Count; j++)
                    {
                        if (Midsorted[i].b < Midsorted[j].b)
                        {

                            temp = Midsorted[i].b;
                            Midsorted[i].b = Midsorted[j].b;
                            Midsorted[j].b = temp;
                        }
                    }
                }
                if (Midsorted != null)
                {
                    foreach (var sorteditem in Midsorted)
                    {
                        Sorted.Add(new Classes.Pairs(sorteditem.a, sorteditem.b));
                    }
                }


            }

            Pairs.Clear();
            foreach (var item in Sorted)
            {
                Pairs.Add(new Classes.Pairs(item.a, item.b));
            }

        }
        public static bool ReflexiveCheck(List<int> Set, List<Pairs> Pairs)
        {

            foreach (var element in Set)
            {
                if (!Classes.Pairs.Contains(Pairs,new Pairs(element, element)))
                {
                    return false;
                }
            }  


            return true;
        }
        public static bool AntiReflexiveCheck(List<int> Set, List<Pairs> Pairs)
        {

            foreach (var element in Set)
            {
                if (Classes.Pairs.Contains(Pairs, new Pairs(element, element)))
                {
                    return false;
                }
            }


            return true;
        }
        public static bool SymmetricCheck(List<Pairs> Pairs)
        {

            foreach (var pair in Pairs)
            {
                if (!Classes.Pairs.Contains(Pairs, new Pairs(pair.b, pair.a)))
                {
                    return false;
                }

            }


            return true;
        }
        public static bool AntiSymmetricCheck(List<Pairs> Pairs)
        {

            foreach (var pair in Pairs)
            {
                if (Classes.Pairs.Contains(Pairs, new Pairs(pair.b, pair.a)))
                {
                    return false;
                }

            }

            return true;
        }
        public static bool TransitiveCheck(List<Pairs> Pairs)
        {
            foreach (var pair in Pairs)
            {
                foreach (var pair2 in Pairs)
                {
                    if (pair.b == pair2.a)
                    {
                        if (!Classes.Pairs.Contains(Pairs, new Pairs(pair.a, pair2.b)))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}

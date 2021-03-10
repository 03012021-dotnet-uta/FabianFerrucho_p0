using System;

namespace SweetSalty
{
    internal class SweetSalty
    {
        private string _salty = "salty";
        private string _sweet = "sweet";
        private string _sweetSalty = "Sweet'nSalty";
        private int countSalty = 0;
        private int countSweet = 0;
        private int countSweetSalty = 0;

        static void Main(string[] args)
        {
            var f = new SweetSalty();
            f.Fizz(1,1000);
        }

        private void Fizz(int a, int b)
        {
            for (var i = a; i <= b; i += 1)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    countSweetSalty++;
                    Console.Write(_sweetSalty + " ");
                }
                else if (i % 3 == 0)
                {
                    countSweet ++;
                    Console.Write(_sweet + " ");
                }
                else if (i % 5 == 0)
                {
                    countSalty ++;
                    Console.Write(_salty + " ");

                }
                else
                {
                    Console.Write(i + " ");
                }
                if(i % 10 ==0)
                {
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine("Total Sweet'nSalty " + countSweetSalty);
            Console.WriteLine("Total Sweet " + countSweet);
            Console.WriteLine("Total Salty " + countSalty);
        }
    }
}

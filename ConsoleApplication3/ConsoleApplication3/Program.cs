using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class enkücüksayıbulma
    {
        public int enkücüksayı(int sayı1, int sayı2)
        {
            int sonuc;

            if (sayı1 > sayı2)
                sonuc = sayı2;
            else
                sonuc = sayı1;
            return sonuc;

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            enkücüksayıbulma sb = new enkücüksayıbulma();
            int sayı1 = 12;
            int sayı2 = 24;

            int sonuc = sb.enkücüksayı(sayı1, sayı2);
            Console.WriteLine("en küçük sayı{0}", sonuc);
            Console.ReadKey();
        }
    }
}

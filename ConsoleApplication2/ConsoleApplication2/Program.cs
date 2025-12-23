using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    public class canlı
    {
        public string ad { get; set; }
        public string cins { get; set; }
    }
    public class kedi : canlı
    {
        public string kyası { get; set; }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            kedi cat = new kedi();
            {
                cat.ad = "tarçın";
                cat.cins = "biritish";
                cat.kyası = "2";
            }
            Console.WriteLine(cat.ad);
            Console.WriteLine(cat.cins);
            Console.WriteLine(cat.kyası);
            Console.ReadKey();
        }
    }
}

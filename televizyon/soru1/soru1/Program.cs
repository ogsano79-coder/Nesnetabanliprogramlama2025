using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru1
{
    public class televizyon
    {
        public int sesSeviyesi;
        public string ekranBoyutu;
        public string görüntüTeknolojisi;



    }

    class Program
    {
        static void Main(string[] args)
        {
            televizyon telvzyn = new televizyon();
            telvzyn.sesSeviyesi = 15;
            telvzyn.ekranBoyutu = "30inc";
            telvzyn.görüntüTeknolojisi = "oled";

            Console.WriteLine("televizyonun ses seviyesi :" +telvzyn.sesSeviyesi);
            Console.WriteLine("televizyonun ekran boyutu :" + telvzyn.ekranBoyutu);
            Console.WriteLine("televizyonun görüntüTeknolojisi :" +telvzyn.görüntüTeknolojisi);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru5
{
    public class televizyon
    {
        public int sesSeviyesi { get; set; }
        public string ekranBoyutu { get; set; }
        public string görüntüTeknolojisi { get; set; }
        public int güçAçKapat();
        public int kanalDeğiştir();
        public int sesseviyesi_oku();       
    }

    class Program
    {
        static void Main(string[] args)
        {                     
            televizyon telvzyn = new televizyon
            {
                sesSeviyesi = 15,
                ekranBoyutu = "30inc",
                görüntüTeknolojisi = "oled"
            };

            Console.WriteLine("televizyonun ses seviyesi :" + telvzyn.sesSeviyesi);
            Console.WriteLine("televizyonun ekran boyutu :" + telvzyn.ekranBoyutu);
            Console.WriteLine("televizyonun görüntüTeknolojisi :" + telvzyn.görüntüTeknolojisi);
            Console.ReadKey();
        }
    }
}

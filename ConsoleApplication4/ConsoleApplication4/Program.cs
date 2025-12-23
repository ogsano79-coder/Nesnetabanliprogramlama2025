using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class truefalse
    {
        public bool turefalse(bool sayı1)
        {
            bool tektir;

            bool çiftdir;
            if (2 % sayı1)
                çiftdir = sayı1;
            else
                tektir = sayı1;


            return tektir;
            return çiftdir;
        }

    }
}


    class Program
    {
        static void Main(string[] args)
        {
            truefalse tf = new truefalse();
            int sayı1 = 10;
            bool tektir = tf.turefalse(sayı1);
            bool çiftdir = tf.turefalse(sayı1);
            Console.WriteLine("büyük olan sayı:", sayı1);
            Console.ReadKey();
        }
    }


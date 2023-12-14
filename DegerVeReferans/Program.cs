using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerVeReferans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = sayi1;
            sayi2 = 50;
            Console.WriteLine("sayı 1 ={0}", sayi1);
            Console.WriteLine("sayı 2 ={0}", sayi2);
            Console.WriteLine("===========================");
            SayiTutucu sayiTutucu = new SayiTutucu();
            sayiTutucu.A = 10;
            SayiTutucu sayiTutucu1 = sayiTutucu;
            sayiTutucu1.A = 50;
            Console.WriteLine("sayı tutucu ={0}",sayiTutucu.A);
            Console.WriteLine("sayı tutucu ={0}",sayiTutucu1.A);
        }
    }
    class SayiTutucu
    {
        public int A { get; set; }
    }
    
}

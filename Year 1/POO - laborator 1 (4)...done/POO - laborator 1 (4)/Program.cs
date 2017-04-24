using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace POO___laborator_1__4_
{
    class Program
    {
        static void Main(string[] args)
        {
            //intr-un fisier text sunt date urmatoarele valori.
            //titlu autor data aparitiei pret.
            //se construieste o clasa book care primeste datele din fisierul text.
            //dupa care se construieste o aplicatie pentru o biblioteca virtuala pentru a gasi cea mai veche carte.
            //si sa identifice valoarea tuturor cartilor.
            TextReader dl = new StreamReader(@"..\..\datain.txt");
            string t;
            while ((t = dl.ReadLine()) != null)
            {
                string[] x = t.Split(';');
                lib.Add(new Book(x[0], x[1], x[2], x[3]));
            }
            int s = 0;
            foreach (Book b in lib)
            {
                Console.WriteLine(b.view());
                s += b.pret;
            }
                Console.WriteLine("Pretul total este "+s);
            Console.ReadKey();
        }
        static List<Book> lib = new List<Book>();
    }
}

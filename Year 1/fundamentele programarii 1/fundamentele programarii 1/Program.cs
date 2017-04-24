using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fundamentele_programarii_1
{
    class Program
    {   
        // readonly este static, nu se poate schimba in program
        private static readonly int MaxValue = 100;
        private static readonly int Max = 1000000;

        static void Main(string[] args)
        {

            // tablouri sau arrays sau vector
            int[] v;

            v = new int[Max];
            // intital elementele vectorului de intregi au valoarea zero
            // fiecare int nou ocupa 4 biti in cazul nostru 40 de biti
            //PrintArray(v);
            
            // ca sa accesam
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = i * i;
            }
            //PrintArray(v);

            //for (int i = 0; i < v.Length; i++)
            //{
            //    v[i] = Util.ExtractInt();
            //}
            //PrintArray(v);

            //int suma = 0;
            //foreach (var item in v)
            //{
            //    suma += item;
            //}
            //Console.WriteLine("suma valorilor introduse este : {0}", suma);

            Random rnd = new Random();
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(MaxValue);
            }
            //PrintArray(v, false);

            int[] frecvente = new int[MaxValue];
            foreach (var item in v)
            {
                frecvente[item]++;
            }
            //PrintArray(frecvente, true);


            //CountingSortPrint(frecvente);
            //introducem in program elementele unui fisier si le afisam dupa aceea il inchidem
            StreamReader sr = new StreamReader("Numere.txt");
            int[] valoriDinFisier;

            string line;
            line = sr.ReadLine();
            int n = int.Parse(line);

            valoriDinFisier = new int[n];

            for(int i = 0; i < n; i++)
            {
                line = sr.ReadLine();
                valoriDinFisier[i] = int.Parse(line);
            }

            //afiseaza elementele din fisier
            foreach (int item in valoriDinFisier)
            {
                Console.WriteLine("{0}", item);
            }

            sr.Close();
            Console.ReadKey();
        }

        private static void CountingSortPrint(int[] frecvente)
        {
            for (int i = 0; i < frecvente.Length; i++)
            {
                for(int j = 0; j < frecvente[i]; j++)
                {
                    Console.Write("{0}", j);
                }
            }
        }

        private static void PrintArray(int[] v, bool withIntex)
        {
            if (withIntex == false)
            {
                // in loc de int putem pune si var.
                // iar item nu se poate folosi ca si item = item * 2
                foreach (int item in v)
                {
                    Console.Write("{0}", item);
                }
            }
            else
            {
                for(int i = 0; i < v.Length; i++)
                {
                    //{2:P} afiseaza procentele
                    Console.WriteLine("{0} - {1} = {2:P}",i,v[i],(double)v[i]/ Max);
                }
            }
        }
    }
}

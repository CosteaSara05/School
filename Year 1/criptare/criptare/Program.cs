
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti textul pentru criptare.");
            string s = Console.ReadLine();
            char[] c = s.ToCharArray();
            string criptat = p1(c);
            Console.WriteLine("Textul criptat: " + criptat);
            p2(criptat);
            Console.ReadKey();
        }

        public static string p1(char[] c)
        {
            int[] numar = new int[c.Length];
            int[] cod = new int[numar.Length];
            string criptat = "";
            for (int i = 0; i < c.Length; i++)
            {
                numar[i] = c[i];
                //Console.Write(numar[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < numar.Length; i++)
            {
                cod[i] = numar[i] + i;
                criptat += (char)cod[i];
            }
            return criptat;
        }

        public static void p2(string criptat)
        {
            Console.WriteLine("Textul decriptat este: ");
            char[] r = new char[criptat.Length];
            r = criptat.ToCharArray();
            char[] v = new char[r.Length];
            List<char> s = new List<char>();
            string b;
            for (int i = 0; i < r.Length; i++)
            {
                 v[i] = (char)((int)r[i] - i);
                s.Add(v[i]);
                Console.Write(s[i]);
            }
        }
    }
}







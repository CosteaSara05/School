using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC_4
{
    class Program
    {
        public class trans
        {
            public char a;
            public string b;
            public trans(char a, string b)
            {
                this.a = a;
                this.b = b;
            }
        }
        static void Main(string[] args)
        {
            List<trans> alfabet = new List<trans>();
            alfabet.Add(new trans('a', ".-"));
            alfabet.Add(new trans('b',"-..."));
            alfabet.Add(new trans('c', "-.-."));
            alfabet.Add(new trans('d', "-.."));
            alfabet.Add(new trans('e', "."));
            alfabet.Add(new trans('f', "..-."));
            alfabet.Add(new trans('g', "--."));
            alfabet.Add(new trans('h', "...."));
            alfabet.Add(new trans('i', ".."));
            alfabet.Add(new trans('j', ".---"));
            alfabet.Add(new trans('k', "-.-"));
            alfabet.Add(new trans('l', ".-.."));
            alfabet.Add(new trans('m', "--"));
            alfabet.Add(new trans('n', "-."));
            alfabet.Add(new trans('o', "---"));
            alfabet.Add(new trans('p', ".--."));
            alfabet.Add(new trans('q', "--.-"));
            alfabet.Add(new trans('r', ".-."));
            alfabet.Add(new trans('s', "..."));
            alfabet.Add(new trans('t', "-"));
            alfabet.Add(new trans('u', "..-"));
            alfabet.Add(new trans('v', "...-"));
            alfabet.Add(new trans('w', ".--"));
            alfabet.Add(new trans('x', "-..-"));
            alfabet.Add(new trans('y', "-.--"));
            alfabet.Add(new trans('z', "--.."));
            alfabet.Add(new trans('1', ".----"));
            alfabet.Add(new trans('2', "..---"));
            alfabet.Add(new trans('3', "...--"));
            alfabet.Add(new trans('4', "....-"));
            alfabet.Add(new trans('5', "....."));
            alfabet.Add(new trans('6', "-...."));
            alfabet.Add(new trans('7', "--..."));
            alfabet.Add(new trans('8', "---.."));
            alfabet.Add(new trans('9', "----."));
            alfabet.Add(new trans('0', "-----"));
            alfabet.Add(new trans(' ', " "));
            
            List<string> b = new List<string>();

            Console.WriteLine("Introduceti textul:");
            string fraza = Console.ReadLine();
            fraza.ToLower();
            for (int j = 0; j < fraza.Length; j++)
                for (int i = 0; i < alfabet.Count; i++)
                    if (fraza[j] == alfabet[i].a)
                        b.Add(alfabet[i].b);

            Console.WriteLine("Fraza in morse: ");
            foreach (string s in b) Console.Write("{0} ", s);

            Console.ReadKey();
        }
    }
}


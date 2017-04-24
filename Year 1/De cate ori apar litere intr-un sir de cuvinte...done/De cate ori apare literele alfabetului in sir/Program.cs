using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De_cate_ori_apare_literele_alfabetului_in_sir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti textul:");
            string text = Console.ReadLine();
            int[] n = new int[26];
            for (int i = 0; i < text.Length; i++)
                if (char.IsLetter(text[i]))
                    n[char.ToLower(text[i]) - 'a']++;
            for (int i = 0; i < 26; i++)
                if (n[i] != 0)
                    Console.WriteLine("{0} apare de {1} ori", (char)(i + 'a'), n[i]);
            Console.ReadKey();
        }
    }
}

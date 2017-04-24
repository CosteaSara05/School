using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AgendacuLista
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader dl = new StreamReader(@"...\...\agenda.txt");
            string t;
            while ((t = dl.ReadLine()) != null)
            {
                string[] x = t.Split(';');
                lib.Add(new Agenda(x[0], x[1], x[2], x[3], x[4]));
            }
            Console.WriteLine("{0}",lib[1]==lib[2]? true :false);

            /*
            for (int i = 0; i < lib.Count; i++)
            {


            }*/

            Console.ReadKey();
        }
        static List<Agenda> lib = new List<Agenda>();
    }
}

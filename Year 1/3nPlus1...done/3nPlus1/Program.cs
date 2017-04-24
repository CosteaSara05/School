using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3nPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            //P1();//vezi secventa.
            //P2();//afla lungimea, numarul la care secventa este cea mai lunga.

            //scrieti o functie oentru care se da n si genereaza sirul pana se ajunge la 1.
            //det cel mai mare numar din secventa.
            //det lungimea secventei.
            //a, b, a < b, det numaru din intervalul a b pentru care se obtine cea mai lunga secventa + 
            //afiseaza lungimea acelei secvente.
            Console.ReadKey();
        }

        private static void P2()
        {
            Console.WriteLine("Introduceti un interval in care sa se faca cautarea celei mai lungi secvente:");
            int n = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int a = n;
            double lungimea = 0, nr = 0, max = 0;


            while (a < b)
            {
                n = a;
                while (n != 1)
                {
                    if (n % 2 == 1)
                    {
                        n = 3 * n + 1;
                    }
                    else
                        n = n / 2;
                    lungimea++;
                    
                    if (max < lungimea)
                    {
                        max = lungimea;
                        nr = a;
                    }
                }
                a++;
                lungimea = 0;
            }
            Console.WriteLine("Lungimea celei mai lungi secvente este {0},  cand numarul este {1}", max, nr);
        }

        private static void P1()
        {
            Console.WriteLine("Introduceti un numar natural pozitiv:");
            int N = int.Parse(Console.ReadLine());
            int maxim;
            int lungime = TreiNPlus1(N, out maxim);
        }

        private static int TreiNPlus1(int n, out int maxim)
        {
            int contor = 1;

            maxim = n;
            Console.Write("La numarul {0} secventa este:", n);
            while (n != 1)
            {
                if (n % 2 == 1)
                {
                    n = 3 * n + 1;
                }
                else
                    n = n / 2;

                if (n > maxim)
                {
                    maxim = n;
                }
                Console.Write("{0} ", n);
                contor++;
            }
            Console.WriteLine();//rand gol.
            Console.WriteLine("Numarul maxim din secventa este {0}", maxim);
            Console.WriteLine("Lungimea secventei este de {0} elemente", contor);
            return contor;
        }
    }
}

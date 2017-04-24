using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ceas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ziua: ");
            int ziua = Convert.ToInt32(Console.ReadLine());
            Console.Write("luna: ");
            int luna = Convert.ToInt32(Console.ReadLine());
            Console.Write("an: ");
            int an = Convert.ToInt32(Console.ReadLine());
            Console.Write("ora: ");
            int ora = Convert.ToInt32(Console.ReadLine());
            Console.Write("minut: ");
            int minut = Convert.ToInt32(Console.ReadLine());
            Console.Write("secunda: ");
            int secunda = 0;
            while (ziua != 50)
            {
                if (secunda > 58)
                {
                    minut++;
                    secunda = 0;
                }
                else
                    secunda++;
                if (minut > 59)
                {
                    ora++;
                    minut = 0;
                }
                if (ora > 23)
                {
                    ora = 0;
                    ziua++;
                }
                switch (luna)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (ziua > 30)
                        {
                            ziua = 1;
                            luna++;
                        }
                        else
                        {
                            ziua++;
                        }
                        break;
                    case 2:
                        if ((an % 400 == 0) || (an % 4 == 0) && (an % 100 != 0))
                            if (ziua > 28)
                            {
                                ziua = 1;
                                luna++;
                            }
                        else
                            if (ziua > 27)
                            {
                                ziua = 1;
                                luna++;
                            }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (ziua > 29)
                        {
                            ziua = 1;
                            luna++;
                        }
                        break;
                }
                if (luna > 12)
                {
                    luna = 1;
                    an++;
                }

               
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("{0:00}:{1:00}:{2:00}", ora, minut, secunda);
                Console.WriteLine("{0:00}/{1:00}/{2:0000}", ziua, luna, an);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace complicat1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            Random r = new Random();
            Console.WriteLine("De cate ori doriti sa se repete testul?");
            int points = 0;
            int[] v = new int[5];
            int contor1 = 0, contor2 = 0, tc = 0, t = Convert.ToInt32(Console.ReadLine());
            sw.Start();
            while(tc < t)
            {
            bool caz1 = false, caz2 = false, caz3 = false, caz4 = false, caz5 = false, caz6 = false, caz7 = false;
                v[0] = r.Next(2, 16);
                v[1] = r.Next(2, 16);
                v[2] = r.Next(2, 16);
                v[3] = r.Next(2, 16);
                v[4] = r.Next(2, 16);
                //v[0] = Convert.ToInt32(Console.ReadLine());
                //v[1] = Convert.ToInt32(Console.ReadLine());
                //v[2] = Convert.ToInt32(Console.ReadLine());
                //v[3] = Convert.ToInt32(Console.ReadLine());
                //v[4] = Convert.ToInt32(Console.ReadLine());
                //for (int i = 0; i < 5; i++)
                //    Console.Write(v[i] + " ");
                //Console.Write(points);
                //Console.WriteLine();

                //cazul 1 : exista 2 valori identice...
                //solutia 1
                for (int i = 0; i < 5; i++)
                for (int j = i + 1; j < 5; j++)
                    if (contor1 == 0)
                        if (v[i] == v[j])
                            contor1++;
            if (contor1 != 0)
            {
                //Console.WriteLine("Exista de 2 valori identice");
                //Console.WriteLine("Exista {0} grupuri de 2 valori identice",contor1);
                caz1 = true;
            }

            //cazul 2 : exista 2 cate 2 valori identice...
            contor1 = 0;
            for (int i = 1; i < 5; i++)
                for (int j = i - 1; j < i; j++)
                    if (v[i] == v[j])
                        contor1++;
            if (contor1 != 0)
            {
                //Console.WriteLine("Exista de valori identice 2 cate 2.");
                //Console.WriteLine("Exista {0} grupuri de valori identice 2 cate 2.",contor1);
                caz2 = true;
            }

            //cazul 3 : exista 3 valori identice...
            contor1 = 0;
            for (int i = 0; i < 5; i++)
                for (int j = i + 1; j < 5; j++)
                    for (int k = j + 1; k < 5; k++)
                        if (contor1 == 0)
                            if ((v[i] == v[j]) && (v[j] == v[k]))
                                contor1++;
            if (contor1 == 1)
            {
                //Console.WriteLine("Exista 3 valori identice.");
                caz3 = true;
            }

            //cazul 4 : exista 3 si 1 in acelasi timp...
            contor1 = 0;
            for (int i = 0; i < 5; i++)
            {
                if (v[i] == 3)
                    contor1++;
                if (v[i] == 1)
                    contor2++;
            }
            if ((contor1 != 0) && (contor2 != 0))
            {
                //Console.WriteLine("Exista 3 si 1 in acelasi timp.");
                caz4 = true;
            }

            //cazul 5 : exista 4 valori identice...
            contor1 = 0;
            for (int i = 0; i < 5; i++)
                for (int j = i + 1; j < 5; j++)
                    for (int k = j + 1; k < 5; k++)
                        for (int l = k + 1; l < 5; l++)
                            if (contor1 == 0)
                                if ((v[i] == v[j]) && (v[j] == v[k]) && (v[k] == v[l]))
                                    contor1++;
            if (contor1 == 1)
            {
                //Console.WriteLine("Exista 4 valori identice.");
                caz5 = true;
            }

            //cazul 6 : exista 5 valori identice
            contor1 = 0;
            for (int i = 0; i < 5; i++)
                for (int j = i + 1; j < 5; j++)
                    for (int k = j + 1; k < 5; k++)
                        for (int l = k + 1; l < 5; l++)
                            for (int m = l + 1; m < 5; m++)
                                if (contor1 == 0)
                                    if ((v[i] == v[j]) && (v[j] == v[k]) && (v[k] == v[l]) && (v[l] == v[m]))
                                        contor1++;
            if (contor1 == 1)
            {
                //Console.WriteLine("Exista 5 valori identice.");
                caz6 = true;
            }
            //cazul 7 : se pot aranja in progresie aritmetica cu ratia 1...
            contor1 = 0;
            for (int i = 1; i < 5; i++)
                for (int j = i - 1; j < i; j++)
                    if (v[i] - v[j] == 1)
                        contor1++;
            if (contor1 == 4)
            {
                //Console.WriteLine("Numerele se pot aranja in progresie aritmetica cu ratia 1.");
                caz7 = true;
            }


                //switch (caz(points, caz1, caz2, caz3, caz4, caz5, caz6, caz7))
                //{
                //    case 1:
                //        Console.WriteLine("Exista de 2 valori identice");
                //    case 2:
                //        Console.WriteLine("Exista de valori identice 2 cate 2.");
                //    case 3:
                //        Console.WriteLine("Exista 3 valori identice.");
                //    case 4:
                //        Console.WriteLine("Exista 3 si 1 in acelasi timp.");
                //    case 5:
                //        Console.WriteLine("Exista 4 valori identice.");
                //    case 6:
                //        Console.WriteLine("Exista 5 valori identice.");
                //    case 7:
                //        Console.WriteLine("Numerele se pot aranja in progresie aritmetica cu ratia 1.");
                //    case 0:
                //        Console.WriteLine("Nimic nou.");
                //}
                if (caz1 == true)
                    points += 1;
                else if (caz2 == true)
                    points += 2;
                else if (caz3 == true)
                    points += 3;
                else if (caz4 == true)
                    points += 4;
                else if (caz5 == true)
                    points += 5;
                else if (caz6 == true)
                    points += 6;
                else if (caz7 == true)
                    points += 7;
                else
                    points += 0;

                tc++;
                if ((tc % 10 == 0) || tc % 10 == 1 || tc % 10 == 2 || tc % 10 == 3 || tc % 10 == 4 || tc % 10 == 5 || tc % 10 == 6) points--;

            }
            sw.Stop();
            Console.WriteLine("Aveti: " + points + (points == 1 ? " punct." : " puncte."));
            Console.WriteLine(sw.Elapsed);

            Console.ReadKey();
        }
        public static int caz(int points,bool caz1, bool caz2, bool caz3, bool caz4, bool caz5, bool caz6, bool caz7)
        {
            if (caz1 == true)
                return 1;
            else if (caz2 == true)
                return 2;
            else if (caz3 == true)
                return 3;
            else if (caz4 == true)
                return 4;
            else if (caz5 == true)
                return 5;
            else if (caz6 == true)
                return 6;
            else if (caz7 == true)
                return 7;
            else
                return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complicat1b
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("De cate ori doriti sa se repete testul?");
            int points = 0;
            int[] v = new int[5];
            int[] al = new int[5];
            int contor1 = 0, contor2 = 0, tc = 0; /*t = Convert.ToInt32(Console.ReadLine())*/
            bool s0 = false, s1 = false, s2 = false, s3 = false, s4 = false;
            do
            {
                bool caz1 = false, caz2 = false, caz3 = false, caz4 = false, caz5 = false, caz6 = false, caz7 = false;
            
                Generare(ref v, s0, s1, s2, s3, s4);

                for (int i = 0; i < 5; i++)
                    Console.Write(v[i] + " ");

                Salveaza(ref v, ref al, s0, s1, s2, s3, s4);

                Cazul1(ref v, caz1);
                Cazul2(ref v, caz2);
                Cazul3(ref v, caz3);
                Cazul4(ref v, caz4);
                Cazul5(ref v, caz5);
                Cazul6(ref v, caz6);
                Cazul7(ref v, caz7);

                caz(ref points, caz1, caz2, caz3, caz4, caz5, caz6, caz7);
                tc++;
                if ((tc % 2 == 0) || (tc % 10 == 1) || (tc % 10 == 2))
                    points--;
                Console.WriteLine("Aveti: " + points + (points == 1 ? " punct." : " puncte."));
                Console.WriteLine("Repetare? Y/N");
                c = Convert.ToChar(Console.ReadLine());
            }
            while (c == 'y');
            //Console.WriteLine("Aveti: " + points + (points == 1 ? " punct." : " puncte."));

            Console.ReadKey();
        }
        public static void Cazul1(ref int[] v,bool caz1)
        {
            //cazul 1 : exista 2 valori identice...
            int contor = 0;
            for (int i = 0; i < 5; i++)
                for (int j = i + 1; j < 5; j++)
                    if (contor == 0)
                        if (v[i] == v[j])
                            contor++;
            if (contor != 0)
                //Console.WriteLine("Exista de 2 valori identice");
                //Console.WriteLine("Exista {0} grupuri de 2 valori identice",contor1);
                caz1 = true;
        }
        public static void Cazul2(ref int[] v, bool caz2)
        {
            //cazul 2 : exista 2 cate 2 valori identice...
            int contor = 0;
            contor = 0;
            for (int i = 1; i < 5; i++)
                for (int j = i - 1; j < i; j++)
                    if (v[i] == v[j])
                        contor++;
            if (contor != 0)
                //Console.WriteLine("Exista de valori identice 2 cate 2.");
                //Console.WriteLine("Exista {0} grupuri de valori identice 2 cate 2.",contor1);
                caz2 = true;
        }
        public static void Cazul3(ref int[] v, bool caz3)
        {
            //cazul 3 : exista 3 valori identice...
            int contor = 0;
            for (int i = 0; i < 5; i++)
                for (int j = i + 1; j < 5; j++)
                    for (int k = j + 1; k < 5; k++)
                        if (contor == 0)
                            if ((v[i] == v[j]) && (v[j] == v[k]))
                                contor++;
            if (contor == 1)
                //Console.WriteLine("Exista 3 valori identice.");
                caz3 = true;
        }
        public static void Cazul4(ref int[] v, bool caz4)
        {
            //cazul 4 : exista 3 si 1 in acelasi timp...
            int contor1 = 0, contor2 = 0;
            for (int i = 0; i < 5; i++)
            {
                if (v[i] == 3)
                    contor1++;
                if (v[i] == 1)
                    contor2++;
            }
            if ((contor1 != 0) && (contor2 != 0))
                //Console.WriteLine("Exista 3 si 1 in acelasi timp.");
                caz4 = true;
        }
        public static void Cazul5(ref int[] v, bool caz5)
        {
            //cazul 5 : exista 4 valori identice...
            int contor = 0;
            for (int i = 0; i < 5; i++)
                for (int j = i + 1; j < 5; j++)
                    for (int k = j + 1; k < 5; k++)
                        for (int l = k + 1; l < 5; l++)
                            if (contor == 0)
                                if ((v[i] == v[j]) && (v[j] == v[k]) && (v[k] == v[l]))
                                    contor++;
            if (contor == 1)
                //Console.WriteLine("Exista 4 valori identice.");
                caz5 = true;
        }
        public static void Cazul6(ref int[] v,bool caz6)
        {
            //cazul 6 : exista 5 valori identice
            int contor = 0;
            for (int i = 0; i < 5; i++)
                for (int j = i + 1; j < 5; j++)
                    for (int k = j + 1; k < 5; k++)
                        for (int l = k + 1; l < 5; l++)
                            for (int m = l + 1; m < 5; m++)
                                if (contor == 0)
                                    if ((v[i] == v[j]) && (v[j] == v[k]) && (v[k] == v[l]) && (v[l] == v[m]))
                                        contor++;
            if (contor == 1)
                //Console.WriteLine("Exista 5 valori identice.");
                caz6 = true;
        }
        public static void Cazul7(ref int[] v, bool caz7)
        {
            //cazul 7 : se pot aranja in progresie aritmetica cu ratia 1...
            int contor = 0;
            for (int i = 1; i < 5; i++)
                for (int j = i - 1; j < i; j++)
                    if (v[i] - v[j] == 1)
                        contor++;
            if (contor == 4)
                //Console.WriteLine("Numerele se pot aranja in progresie aritmetica cu ratia 1.");
                caz7 = true;
        }

        public static int caz(ref int points, bool caz1, bool caz2, bool caz3, bool caz4, bool caz5, bool caz6, bool caz7)
        {
            if (caz1 == true)
                return points += 1;
            else if (caz2 == true)
                return points += 2;
            else if (caz3 == true)
                return points += 3;
            else if (caz4 == true)
                return points += 4;
            else if (caz5 == true)
                return points += 5;
            else if (caz6 == true)
                return points += 6;
            else if (caz7 == true)
                return points += 7;
            else
                return points += 0;
        }
        public static void Salveaza(ref int[] v, ref int[] al, bool s0, bool s1, bool s2, bool s3, bool s4)
        {
            Console.WriteLine("Doresti sa salvezi o pozitie? Y/N");
            char vb = Convert.ToChar(Console.ReadLine());
            if (vb == 'y')
            {
                Console.WriteLine("Ce pozitie doresti sa salvezi?");
                int con = Convert.ToInt32(Console.ReadLine());
                switch (con)
                {
                    case 0:
                        {
                            Alege(ref v, ref al, s0 = true, s1 = false, s2 = false, s3 = false, s4 = false);
                            break;
                        }
                    case 1:
                        {
                            Alege(ref v, ref al, s0 = false, s1 = true, s2 = false, s3 = false, s4 = false);
                            break;
                        }
                    case 2:
                        {
                            Alege(ref v, ref al, s0 = false, s1 = false, s2 = true, s3 = false, s4 = false);
                            break;
                        }
                    case 3:
                        {
                            Alege(ref v, ref al, s0 = false, s1 = false, s2 = false, s3 = true, s4 = false);
                            break;
                        }
                    case 4:
                        {
                            Alege(ref v, ref al, s0 = false, s1 = false, s2 = false, s3 = false, s4 = true);
                            break;
                        }
                }
            }
        }
        public static void Alege(ref int[] v, ref int[] al, bool s0, bool s1, bool s2, bool s3, bool s4)
        {
            if (s0 == true) al[0] = v[0];
            if (s1 == true) al[1] = v[1];
            if (s2 == true) al[2] = v[2];
            if (s3 == true) al[3] = v[3];
            if (s4 == true) al[4] = v[4];
        }
        public static void Generare(ref int[] v, bool s0, bool s1, bool s2, bool s3, bool s4)
        {
            Random r = new Random();
            if (s0 == false) v[0] = r.Next(2, 16);
            if (s1 == false) v[1] = r.Next(2, 16);
            if (s2 == false) v[2] = r.Next(2, 16);
            if (s3 == false) v[3] = r.Next(2, 16);
            if (s4 == false) v[4] = r.Next(2, 16);
        }
    }
}

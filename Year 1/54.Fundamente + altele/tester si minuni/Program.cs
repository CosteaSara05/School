using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace tester_si_minuni
{
    class Program
    {

        static void Main(string[] args)
        {
			Console.WriteLine("suma secventa.");
			P1();
			//console.writeline("cal mai mare numar.");
			//p2();
			//console.writeline("secventa crescatoare.");
			//p3();
			//Console.WriteLine("Sirul Lui Fibonacci.");
			//P4();
			//Console.WriteLine("Baze.");
			//p5();
			//Console.WriteLine("11.Test de primalitate pe baza calculului numărului de divizori");
			//p6();
			//Console.WriteLine("16.Algoritm de determinare dacă un număr este palindrom");
			//p7();
			//Console.WriteLine("cel mai mare numar intreg.");
			//p8();
			//Console.WriteLine("13.Suma cifrelor unui număr");
			//p9();
			//Console.WriteLine("Hello World!! pe verticala.");
			//p10();
			//Console.WriteLine("Afisare in octal si hexazecimal a unui numar intreg.");
			//p11();
			//Console.WriteLine("Din caracter in ASCII.");
			//p12();
			//Console.WriteLine("Transforma din litera mica in majuscula folosind ASCII.");
			//p13();
			//Console.WriteLine("Transforma un cuvant din litere mici in majuscule.");
			//p14();
			//Console.WriteLine("Descompune in factori primi.");
			//p15();
			//Console.WriteLine("Afla numarul de cuvinte.");
			//p16();
			//Console.WriteLine("Transforma prima litera din fiecare cuvant in litera mare.");
			//p17();'
			//Console.WriteLine("Transforma prima litera dintr-o propozitie in litera mare");
			//p18();
			//Console.WriteLine("Cauta un text intr-un text.");
			//p19();
			//Console.WriteLine("Ex 1. Examen fundamentele programarii");
			//p20();
			//Console.WriteLine("Ordoneaza un sir crescator.");
			//p21();
			//Console.WriteLine("Aranjamente n luate cate k:");
			//p22();
			//Console.WriteLine("9.Calculul factorialului (iterativ)");
			//p23();
			//Console.WriteLine("Combinari n luate cate k");
			//p24();
			//Console.WriteLine("Se da un nr si formam nr minim. Metoda 1");
			//p25();
			//Console.WriteLine("Se da un nr, obtinem cu vectorul caracteristic si formam nr minim. Metoda 2");
			//p26();
			//Console.WriteLine("Se da un nr si formam nr minim, < ultima cifra la stanga, > uc la dreapta. Metoda 3");
			//p27();
			//Console.WriteLine("1.Să se construiască un algoritm care calculează aria unui triunghi pentru care se cunosc laturile acestuia");
			//p28();
			//Console.WriteLine("2.Construiţi un algoritm care transformă o valoare dată în grade celsius în valoarea corespunzătoare în grade Farenheid");
			//p29();
			//Console.WriteLine("3.Minimul dintre 2,3, şi 4 numere citite de la tastatură");
			//p30();
			//Console.WriteLine("4.Se dau 3,4 sau 5 numere întregi să se detemine dacă există 2 sau 3 valori identice");
			//p31();
			//Console.WriteLine("Minimul intr-un vector.");
			//p32();
			//Console.WriteLine("Inversarea unui vector.");
			//p33();
			//Console.WriteLine("27.Norma, suma şi produsul elementelor unui vector");
			//p34();
			//Console.WriteLine("31.Bouble sort clasic.");
			//p35();
			//Console.WriteLine("Bouble sort optimizat.");
			//p36();
			//Console.WriteLine("29.Selection sort clasic.");
			//p37();
			//Console.WriteLine("Selection sort cu max pe ultima pozitie.");
			//p38();
			//Console.WriteLine("Selection sort cu min pe prima pozitie si max pe ultima pozitie.");
			//p39();
			//Console.WriteLine("5.Construiţi un algoritm pentru rezovarea ecuaţiei de grad II");
			//p40();
			//Console.WriteLine("6.Calculul în diferite puncte pentru unele funcţii matematice definite pe porţiuni");
			//p41();
			//Console.WriteLine("7.Se dau 3 numere întregi să se afişeza în ordine crescătoare");
			//p42();
			//Console.WriteLine("30.Sortare directa.");
			//p43();
			//Console.WriteLine("Vector cu elemente unice.");
			//p44();
			//Console.WriteLine("Vector mic intra in vector mare");
			//p45();
			//Console.WriteLine("8.Ridicarea la putere a unui număr (iterativ)");
			//p46();
			//Console.WriteLine("10.Calculul sumei primelor n numere naturale (iterativ şi comaparea rezultatelor cu formula lui Gauss)");
			//p47();
			//Console.WriteLine("12.Transformări de baze");
			//p48();
			//Console.WriteLine("14.Minimul cifrelor unui număr");
			//p49();
			//Console.WriteLine("15.Sa se genereze oglinditul unui numar");
			//p50();
			//Console.WriteLine("17.Algoritm de determinare dacă un număr are cifrele în ordine crescătoare / descrescătoare");
			//p51();
			//Console.WriteLine("18.Suma numerelor. Se introduc numere de la tastatură, pȃnă la valoarea -1.");
			//p52();
			//Console.WriteLine("19.Minimul/Maximul acestora. Se introduc numere de la tastatură, pȃnă la valoarea -1.");
			//p53();
			//Console.WriteLine("20.Numărul de numere prime. Se introduc numere de la tastatură, pȃnă la valoarea -1.");
			//p54();
			//Console.WriteLine("21.Media aritmetică. Se introduc numere de la tastatură, pȃnă la valoarea -1.");
			//p55();
			//Console.WriteLine("22.Determinarea numarului de aparitii a unui caracter intr-un text introdus de la tastarura");
			//p56();
			//Console.WriteLine("23.Construirea algoritmică a funcţiilor definite pe şiruri de caractere din C/C++ (strcpy, strcat, strlen,strncat ... ), adaptate pentru variabile de tip string din C#.");
			//p57();
			//Console.WriteLine("24.Crearea si afisarea unui sir de caractere format din caractere introduse de la tastatura unul cate unul");
			//p58();
			//Console.WriteLine("25.Algoritm de transformare a unui şir de caractere în număr întreg");
			//p59();
			//Console.WriteLine("26.Algoritm de transformare a unui şir de caractere în număr real");
			//p60();
			//Console.WriteLine("28.Minmul sau maximul elementelor unui vector");
			//p61();
			//Console.WriteLine("32.Sortarea prin insertie");
			//p62();
			//Console.WriteLine("33.Implementarea algortimului lui Sarus pentru calculul determinantului unei matrici de 3x3");
			//p63();
			//Console.WriteLine("Ciurul lui Eratostene");
			//p64();
			//Console.WriteLine("34.Suma a două matrici");
			//p65();
			//Console.WriteLine("35.Identificarea diagonalelor într-o matrice şi calculul urmei unei matrici");
			//p66();
			//Console.WriteLine("36.Transpusa unei matrici");
			//p67();
			//Console.WriteLine("37.Determinarea numarului de numere prime introduse de la tastatura cu ajutorul unei functii care determina daca un numar este prim");
			//p68();
			//Console.WriteLine("38.Rezolvarea problemei ce presupune calculul sumei a doua matrici, dar utilizandu-se functii pentru citirea, scrierea si adunarea matricilor");
			//p69();
			//Console.WriteLine("39.Construirea tipului de dată număr complex şi implementarea operatorilor de adunare, normă, înmulţire a acestor numere");
			//p70();
			//Console.WriteLine("40.Construirea tipului de dată număr raţional şi implementarea principalilor operatori pentru aceste numere.");
			//p71();
			//Console.WriteLine("41.Funcţia factorial");
			//p72();
			//Console.WriteLine("42.Generarea şirului lui Fibonacci");
			//p73();
			//Console.WriteLine("43.Transformarea unor algoritmi iterativi în algoritmi recursivi (Bubble Sort)");
			//p74();
			//Console.WriteLine("44.Simularea instructiunii FOR cu ajutorul unei functii recursive");
			//p75();
			//Console.WriteLine("45.Generarea indicilor unui tablou multidimensionali cu ajutorul unei functii recursive");
			//p76();
			//Console.WriteLine("46.Realizarea unui program care citeşte date întregi dintr-un fişier, reprezentȃnd un vector de dimensiune n");
			//p77();
			//Console.WriteLine("47.Copierea datelor dintr-un fişier în altul");
			//p78();
			//Console.WriteLine("48.Adăugarea datelor dintr-un fişier în altul.");
			//p79();
			//Console.WriteLine("49.Sa se determine numarul de aparitii a caracterelor alfabetului englez intr-un fisier, fara a tine cont daca sunt litere mici sau mari");
			//p80();
			//Console.WriteLine("50.Sa se determine de cate ori apare un sir dat intr-un fisier");
			//p81();
			//Console.WriteLine("51.Generarea unei permutări a unei mulţimi");
			//p82();
			//Console.WriteLine("52.Implementarea algoritmului jocului „ghiceşte numărul”");
			//p83();
			//Console.WriteLine("53.Generarea unor numere cu diferite restricţii (cifre distincte)");
			//p84();
			//Console.WriteLine("54.Generarea unor serii de numere cu diferite restricţii (numere crescătoare într-un anumit interval)");
			//p85();


			Console.ReadKey();

        }

        private static void p85()
        {
            Random r = new Random();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = r.Next(a, b + 1);
            int m = x;
            Console.Write(x);
            while (x <= b && m != b)
            {
                x = r.Next(m + 1, b);
                m = x;
                Console.Write(" " + x);
            }
        }
        public static int ValidN(int x, int[] v)
        {
            if (v[x] == 1)
                return 0;

            return 1;
        }


        private static void p84()
        {
            Random r = new Random();
            int[] v = new int[10];

            for (int i = 0; i < 10; i++)
                v[i] = 0;
            Console.WriteLine("Introdu un numar: ");
            int x, nrc = int.Parse(Console.ReadLine());
            long nr = 0;

            for (int i = 1; i <= nrc; i++)
            {
                x = r.Next(0, 10);
                while (ValidN(x, v) == 0)
                    x = r.Next(0, 10);

                v[x] = 1;
                nr = nr * 10 + x;
            }
            Console.WriteLine(nr);

        }

        private static void p83()
        {
            Random r = new Random();
            int x, p;
            Console.WriteLine("Introdu numere:");
            x = r.Next(0, 100);
            p = 0;
            int nr = Convert.ToInt32(Console.ReadLine());
            p++;
            while (nr != x)
            {
                if (nr > x)
                    Console.WriteLine("Ati introdus un numar mai mare.");
                if (nr < x)
                    Console.WriteLine("Ati introdus un numar mai mic.");
                nr = Convert.ToInt32(Console.ReadLine());
                p++;
            }
            if (nr == x)
                Console.WriteLine("Ati descoperit numarul din a {0}-a incercare", p);
        }

        private static int ToValidate(int rnd, int[] ap)
        {
            if (ap[rnd] != 0)
                return 0;
            return 1;
        }


        private static void p82()
        {
            Console.Write("Dati numarul de elemente ale multimii:");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Elementul numarul: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}: ", i);
                v[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");

            Random rnd = new Random();
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
                b[i] = 0;

            Console.WriteLine();
            Console.Write("Permutat: ");
            for (int i = 1; i <= n; i++)
            {
                int c = rnd.Next(0, n);
                while (ToValidate(c, b) == 0)
                    c = rnd.Next(0, n);
                b[c] = 1;
                Console.Write(v[c] + " ");
            }
        }

        private static void p81()
        {
            StreamReader sr = new StreamReader(@"..\..\p81.txt");
            string t;
            Console.Write("Introduceti sirul cautat:");
            string s = Console.ReadLine();
            int nr = 0;
            t = sr.ReadLine();
            int p;
            while (t != null)
            {

                p = t.IndexOf(s, 0);
                while (p != -1)
                {
                    p = t.IndexOf(s, p + s.Length);
                    nr++;
                }
                t = sr.ReadLine();
            }
            Console.WriteLine("Sirul {0} apare de {1} ori.", s, nr);
        }

        private static void p80()
        {
            StreamReader sr = new StreamReader(@"../../eng.txt");
            int n = 0;
            string t = sr.ReadLine();
            while (t != null)
            {
                for (int i = 0; i < t.Length; i++)
                    if (char.IsLetter(t[i]))
                        n++;
                t = sr.ReadLine();
            }
            Console.WriteLine("Numarul de litere este: " + n);
        }

        private static void p79()
        {
            StreamReader sr = new StreamReader(@"../../p46.txt");
            StreamWriter sw = new StreamWriter(@"../../add.txt", true);
            string t = sr.ReadLine();
            while (t != null)
            {
                sw.WriteLine(t);
                t = sr.ReadLine();
            }
            Console.WriteLine("done");
            sr.Close();
            sw.Close();
        }

        private static void p78()
        {
            StreamReader sr = new StreamReader(@"../../p46.txt");
            StreamWriter sw = new StreamWriter(@"../../p47copy.txt");
            string t = sr.ReadLine();
            while (t != null)
            {
                sw.WriteLine(t);
                t = sr.ReadLine();
            }
            Console.WriteLine("done");
            sr.Close();
            sw.Close();
        }

        private static void p77()
        {
            int suma = 0;
            string fileContent = File.ReadAllText("p46.txt");
            string[] integerStrings = fileContent.Split(new char[] { ';', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int[] integers = new int[integerStrings.Length];
            for (int n = 0; n < integerStrings.Length; n++)
            {
                integers[n] = int.Parse(integerStrings[n]);
                suma = suma + integers[n];
            }
            Console.WriteLine("Suma este " + suma);
        }

        private static void p76()
        {
            Console.Write("Dati ordinul matricei:");
            int i = 0, n = int.Parse(Console.ReadLine());
            genrec(i, n);

        }

        private static void genrec(int i, int n)
        {
            if (i == n)
                return;
            else
            {
                for (int j = 0; j < n; j++)
                    Console.Write("({0},{1})  ", i, j);
                Console.WriteLine();
                genrec(i + 1, n);
            }
        }

    private static void p75()
        {
            Console.WriteLine("Introduceti numerele dorite");
            int suma = 0;
            numere(suma);
        }

        private static void numere(int suma)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n != 0)
            {
                suma = n + suma;
                numere(suma);
            }
            else
                Console.WriteLine(suma);

        }

        private static int bubblesort(int[] v, int n)
        {
            if (n == 0)
                return 0;
            int i, t;
            for (i = 0; i < n - 1; i++)
                if (v[i] > v[i + 1])
                {
                    t = v[i + 1];
                    v[i + 1] = v[i];
                    v[i] = t;
                }
            return bubblesort(v, n - 1);
        }


        private static void p74()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = Convert.ToInt32(Console.ReadLine());

            bubblesort(v, n);
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
        }

        private static void p73()
        {
            Console.Write("Introduceti pozitia pana la care sa se genereze sirul: ");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.Write("Valoarea de la pozitia " + p + " este:");
            Console.WriteLine("Loading...");
            Console.WriteLine(fibonacci(p));
        }

        private static ulong fibonacci(int p)
        {
            if (p == 0)
                return 0;

            if (p == 1)
                return 1;

            return fibonacci(p - 1) + fibonacci(p - 2);
        }

        private static void p72()
        {
            Console.WriteLine("Introduceti numarul: (maxim 65)");
            ulong n = Convert.ToUInt64(Console.ReadLine());
            if (n < 1)
                Console.WriteLine("Nu se poate face factorial");

            else
                Console.WriteLine("Factorialul este: " + factorial(n));
        }

        private static ulong factorial(ulong n)
        {
            ulong t = n;

            if (n <= 1)
                return 1;

            if (n > 0)
                t = n * factorial(n - 1);
            return t;
        }

        public struct rational
        {
            public double x;
        }

        public static rational a = new rational();
        public static rational b = new rational();
        private static void p71()
        {
            Console.WriteLine("Introduceti numerele: ");
            Console.WriteLine("a: ");
            a.x = double.Parse(Console.ReadLine());
            Console.WriteLine("b: ");
            b.x = double.Parse(Console.ReadLine());

            double s = a.x + b.x;
            Console.WriteLine("suma celor 2 numere rationale este: " + s);

            double dif = a.x - b.x;
            Console.WriteLine("Diferenta este: " + dif);

            double p = a.x * b.x;
            Console.WriteLine("Produsul celor 2 numere rationale este: " + p);

            double cat = a.x / b.x;
            Console.WriteLine("a / b = " + cat);

            double pow = Math.Pow(a.x, b.x);
            Console.WriteLine("a ^ b = " + pow);
        }
    

        public struct complex
        {
            public int a;
            public int b;
        }
        private static void p70()
        {
            complex n1 = new complex();
            complex n2 = new complex();

            Console.Write("Partea reala a primului numar complex este:");
            n1.a = int.Parse(Console.ReadLine());
            Console.Write("Coeficientul partii imaginare a primului numar este:");
            n1.b = int.Parse(Console.ReadLine());
            Console.Write("Partea reala a celui de-al doi-lea numar complex este:");
            n2.a = int.Parse(Console.ReadLine());
            Console.Write("Coeficientul partii imaginare a celui de-al doi-lea numar este:");
            n2.b = int.Parse(Console.ReadLine());

            complex suma = adunarecom(n1,n2);
            double n = normacom(suma);
            complex produs = produscom(n1,n2);

            Console.WriteLine("Suma celor 2 nr complexe este:{0}+{1}i", suma.a, suma.b);
            Console.WriteLine("Norma sumei celor 2 nr complexe este:{0}", n);
            Console.WriteLine("Produsul celor 2 nr complexe este:{0}+{1}i", produs.a, produs.b);
        }

        private static complex produscom(complex n1, complex n2)
        {
            complex p = new complex();
            p.a = n1.a * n2.a - n1.b * n2.b;
            p.b = n1.a * n2.b + n1.b * n2.a;
            return p;
        }


        private static double normacom(complex n1)
        {
            double n = 0;
            n = Math.Pow(n1.a, 2) + Math.Pow(n1.b, 2);
            n = Math.Sqrt(n);
            return n;
        }


        private static complex adunarecom(complex n1, complex n2)
        {
            complex suma = new complex();
            suma.a = n1.a + n2.a;
            suma.b = n1.b + n2.b;
            return suma;
        }

        private static void p69()
        {
            Console.Write("Numarul de coloane din cele 2 matrici = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numarul de randuri din cele 2 matrici = ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] c = new int[n, m];
            int[,] d = new int[n, m];

            Console.WriteLine("Prima: ");
            citireMatrice(c, n, m);
            Console.WriteLine("A 2-a: ");
            citireMatrice(d, n, m);
            viewMatrice(c, n, m);
            viewMatrice(d, n, m);
            adunarea2Matrici(c, d, n, m);
            viewMatrice(c, n, m);
        }

        private static void adunarea2Matrici(int[,] a, int[,] b, int n, int m)
        {
            int[,] c = new int[n, m];
                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        a[i, j] += b[i, j];
        }

        private static void viewMatrice(int[,] a, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m; j++)
                    Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }

        private static void citireMatrice(int[,] x,int n, int m)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0},{1} = ", i, j);
                    x[i, j] = Convert.ToInt32(Console.ReadLine());
                }
        }

        private static void p68()
        {
            int n = ExtractInt();
            int[] v = new int[n];
            List<int> b = new List<int>{1};
            for (int i = 2; i <= n; i++)
                if (prim(i, n) == true)
                    b.Add(i);

            //foreach (var item in b)
            //    Console.WriteLine(item);

            Console.WriteLine("Sunt " + b.Count + " numere prime.");
        }

        public static bool prim(int i, int n)
        {
            int c = 0, d = 2;
            bool p;
            while ((d <= n / 2) && (c < 3))
            {
                if (i % d == 0)
                    c++;
                d++;
            }
            if (c == 1)
                return p = true;
            else
                return p = false;
        }

        private static void p67()
        {
            int n1, m1;

            Console.Write("Numarul de coloane din prima matrice = ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numarul de randuri din prima matrice = ");
            m1 = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[n1, m1];
            for (int i = 0; i < n1; i++)
                for (int j = 0; j < m1; j++)
                {
                    Console.Write("{0},{1} = ", i, j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            if (n1 == m1)
            {
                for (int i = 0; i < n1; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < m1; j++)
                        Console.Write(A[i, j] + " ");
                }
            }
            else
            {
                int t = n1;
                n1 = m1;
                m1 = t;
                for (int i = 0; i < n1; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < m1; j++)
                        Console.Write(A[j, i] + " ");
                }
            }
        }

        private static void p66()
        {
            int n1, m1, u = 0;

            Console.Write("Numarul de coloane din prima matrice = ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numarul de randuri din prima matrice = ");
            m1 = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[n1, m1];
            for (int i = 0; i < n1; i++)
                for (int j = 0; j < m1; j++)
                {
                    Console.Write("{0},{1} = ", i, j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            if (n1 == m1)
            {
                Console.WriteLine("Diagonala principala este");
                for (int i = 0; i < n1; i++)
                        Console.Write(A[i,i] + " ");

                Console.WriteLine("Diagonala secundara este");
                for (int i = 0; i < n1; i++)
                    Console.Write(A[i, n1 - 1 - i] + " ");
            }

            if (n1 != m1)
                Console.WriteLine("Nu se poate face calculul.");
            else
            {
                for (int i = 0; i < n1; i++)
                    u = A[i, i] + u;

                Console.WriteLine("Urma matricei este: " + u);
            }

        }

        private static void p65()
        {
            int n1, m1, n2, m2;

            Console.Write("Numarul de coloane din prima matrice = ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numarul de randuri din prima matrice = ");
            m1 = Convert.ToInt32(Console.ReadLine());
            int[,] A = new int[n1, m1];
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m1; j++)
                {
                    Console.Write("{0},{1} = ", i, j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Numarul de coloane din a doua matrice = ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numarul de randuri din a doua matrice = ");
            m2 = Convert.ToInt32(Console.ReadLine());
            int[,] B = new int[n2, m2];
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    Console.Write("{0},{1} = ", i, j);
                    B[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Matricea A:");
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m1; j++)
                    Console.Write("{0} ", A[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine("Matricea B:");
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                    Console.Write("{0} ", B[i, j]);
                Console.WriteLine();
            }

            if (n1 == n2 && m1 == m2)
            {
                int[,] C = new int[n1, m1];
                Console.WriteLine("Suma Matricelor:");
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < m1; j++)
                    {
                        C[i, j] = A[i, j] + B[i, j];
                    }
                }
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < m2; j++)
                        Console.Write("{0} ", C[i, j]);
                    Console.WriteLine();
                }

            }
        }

        private static void p64()
        {
            Stopwatch sw = new Stopwatch();
            ulong n = ulong.Parse(Console.ReadLine());
            ulong[] c = new ulong[n + 1];
                c[1] = 1;
            sw.Start();
            for (ulong i = 2; i <= n; i++)
            {
                ulong e = 2, co = 0, d = e;
                if(n <= 1000)
                while (e <= (ulong)Math.Sqrt(n))
                {
                    if (i % e == 0)
                    {
                        co++;
                        d = e;
                    }
                    e++;
                }
                else
                    while (e <= (ulong)Math.Log10(n))
                    {
                        if (i % e == 0)
                        {
                            co++;
                            d = e;
                        }
                        e++;
                    }

                if (co != 0)
                    for (ulong j = d; i * j <= n; j++)
                        c[i * j] = 1;
                if (co == 0)
                        c[i] = 0;
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.WriteLine("Care numar doriti sa vedeti daca este prim? ");

                ulong x = ulong.Parse(Console.ReadLine());
                if (c[x] == 0)
                    Console.WriteLine("Numarul este prim.");
                else
                    Console.WriteLine("Numarul nu este prim.");

            //for (ulong i = 1; i <= n; i++)
            //    if (c[i] == 0)
            //        Console.Write(i + " ");
        }

        private static void p63()
        {
            Random r = new Random();
            int m1 = 3, n1 = 3;

            int[,] a = new int[n1, m1];
            for (int i = 0; i < n1; i++)
                for (int j = 0; j < m1; j++)
                {
                    //Console.Write("{0},{1} = ", i, j);
                    a[i, j] = r.Next(10);
                }
            int d = a[0, 0] * a[1, 1] * a[2, 2] + a[1, 0] * a[2, 1] * a[0, 2] + a[2, 0] * a[0, 1] * a[1, 2] - a[0, 2] * a[1, 1] * a[2, 0] - a[1, 2] * a[2, 1] * a[0, 0] - a[2, 2] * a[0, 1] * a[1, 0];
            Console.WriteLine("Determinantul este: " + d);
        }

        private static void p62()
        {
            int n;
            List<int> u = new List<int>();
            u.Add(n = ExtractInt());
            u.Add(n = ExtractInt());
                for (int i = 0; i < u.Capacity; i++)
                {
                if (n != 0)
                {

                    int j = i + 1;
                    while ((j > 0) && (u[j] < u[j - 1]))
                    {
                        int k = j - 1;
                        int temp = u[k];
                        u[k] = u[j];
                        u[j] = temp;

                        j--;
                    }
                    //for (int l = 0; l < u.Capacity; l++)
                    //    Console.Write(u[l] + " ");
                    u.Add(n = ExtractInt());
                }
                }
            foreach(var item in u)
                Console.Write(item + " ");

        }

        private static void p61()
        {
            int[] v = ExtractVector();
            int min = int.MaxValue, max = int.MinValue;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] < min)
                    min = v[i];
                if (v[i] > max)
                    max = v[i];
            }
            Console.WriteLine("Minimul: " + min);
            Console.WriteLine("Maximul: " + max);
        }

        private static void p60()
        {
            Console.WriteLine("Introduceti textul: ");
            string t = Console.ReadLine();
            char[] c = t.ToCharArray();
            double suma = 0;
            for (int i = 0; i < c.Length; i++)
                suma += c[i];
            Console.WriteLine("Suma totala a sirului este: " + suma);
        }

        private static void p59()
        {
            Console.WriteLine("Introduceti textul: ");
            string t = Console.ReadLine();
            char[] c = t.ToCharArray();
            int suma = 0;
            for (int i = 0; i < c.Length; i++)
                suma += c[i];
            Console.WriteLine("Suma totala a sirului este: " + suma);
        }

        private static void p58()
        {
            Console.WriteLine("Introduceti litere unul cate unul. Cand apasati ` , procesul se incheie.");
            char[] t = new char[100];
            char c = char.Parse(Console.ReadLine());
            int i = 0;
            while (c != 96)
            {
                t[i] = c;
                Console.WriteLine(t);
                c = char.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("Tot textul este ");
            for (int j = 0; j <= i; j++)
            Console.Write(t[j]);
        }

        private static void p57()
        {
            Console.WriteLine("Introduceti primul text: ");
            StringBuilder t = new StringBuilder(Console.ReadLine());
            Console.WriteLine("Introduceti cel de-al doilea text: ");
            StringBuilder s = new StringBuilder(Console.ReadLine());
            
            //strcpy
            Console.WriteLine("Strcpy");
            int nt = t.Length, ns = s.Length;
            StringBuilder tc = new StringBuilder(t.ToString());
            nt = ns;
            for (int i = 0; i < nt; i++)
                t[i] = s[i];
            Console.WriteLine(t);
            
            //strcat
            Console.WriteLine("strcat");
            nt = t.Length;
            t.Length = t.Length + s.Length + 1;
            if (t.Length >= s.Length)
            {
                for (int i = nt + 1; i < t.Length; i++)
                    t[i] = s[i - nt - 1];
                Console.WriteLine(t);
            }
            else
                Console.WriteLine("Nu se poate face strcat");

            //strlen
            Console.WriteLine("strlen");
            t.Length = t.Length - s.Length - 1;
            Console.WriteLine("t = " + t.Length);

            //strncat
            Console.WriteLine("strncat");
            Console.WriteLine("Cate caractere din primul text doriti sa se stearga pentru a incepe sa se adauge din al doilea?");
            int j = int.Parse(Console.ReadLine());
            t.Length = t.Length;
            for (int i = 0; i < j; i++)
                tc[t.Length - j + i] = s[i];
            Console.WriteLine(tc);
        }

        private static void p56()
        {
            Console.WriteLine("Introduceti textul.");
            string t = Console.ReadLine();
            char[] c = t.ToLower().ToCharArray();
            int n = 0;
            Console.WriteLine("Introduceti litera cautata.");
            char cc = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < c.Length; i++)
                    if (c[i] == cc)
                        n++;
                Console.Write(cc + " = " + n);


        }

        private static void p55()
        {
            int n = ExtractInt();
            double ma = 0;
            while (n != -1)
            {
                ma = ma + n;
                n = ExtractInt();
            }
            ma = ma / 2;
            Console.WriteLine("Media aritmetica este: " + ma);

        }

        private static void p54()
        {
            int n = ExtractInt(), c = 0, prim = 0,d0 = 0;
            while (n != -1)
            {
                d0 = 0;
                c = 0;
                for (int d = 2; d <= (int)Math.Sqrt(n); d++)
                {
                    if (n % d == 0)
                        c++;
                    d0++;
                }
                if ((n == 3) || (n == 1) || (n == 2))
                {
                    c = 0;
                    d0++;
                }
                if ((c == 0) && (d0 != 0))
                    prim++;

                    Console.WriteLine(prim);
                
                    n = ExtractInt();
            }
            Console.WriteLine("In secventa sunt: " + prim + " numere prime.");
        }

        private static void p53()
        {
            int n = ExtractInt(), min = int.MaxValue, max = int.MinValue;
            while (n != -1)
            {
                if (n < min)
                    min = n;
                if (n > max)
                    max = n;
                Console.WriteLine("Minimul: " + min);
                Console.WriteLine("Maximul: " + max);
                n = ExtractInt();
            }
            Console.WriteLine("Minimul: " + min);
            Console.WriteLine("Maximul: " + max);
        }

        private static void p52()
        {
            int n = ExtractInt(), suma = 0;
            while (n != -1)
            {
                suma += n;
                Console.WriteLine("Suma este: " + suma);
                n = ExtractInt();
            }
            Console.WriteLine("Suma este: " + suma);
        }

        private static void p51()
        {
            int n = ExtractInt(), uc1, uc2, nc1 = n, nc2 = n;
            bool ok1 = false, ok2 = false;
            while (nc1 >= 10)
            {
                uc1 = nc1 % 10;
                nc1 /= 10;
                uc2 = nc1 % 10;
                if (uc1 - uc2 >= 1)
                {
                    ok1 = true;
                    if (uc1 - uc2 == 0)
                    {
                        ok1 = true;
                    }
                }
                if (uc1 - uc2 <= -1)
                {
                    ok2 = true;
                    if (uc1 - uc2 == 0)
                    {
                        ok1 = true;
                    }
                }
            }
            if ((ok1 == true) && (ok2 == false))
                Console.WriteLine("Numarul este crescator");
            if ((ok1 == false) && (ok2 == true))
                Console.WriteLine("Numarul este descrescator");
            if (ok1 && ok2 == true)
                Console.WriteLine("Numarul nu este constant");
        }

        private static void p50()
        {
            int n = ExtractInt(), uc, nc = 0;
            while (n > 0)
            {
                uc = n % 10;
                n /= 10;
                nc = nc * 10 + uc;
            }
            Console.WriteLine("Numarul intors este " + nc);
        }

        private static void p49()
        {
            int n = ExtractInt(), p = 0, min = int.MaxValue, uc;
            while (n > 0)
            {
                p++;
                for (int i = 0; i < p; i++)
                {
                    uc = n % 10;
                    if (uc < min)
                        min = uc;
                }
                n /= 10;
            }
            Console.WriteLine("Cifra minima este " + min);
        }

        private static void p48()
        {
            //din baza 10 in baza 16.
            int i = 0;
            Console.Write("Introduceti numarul in baza 10:");
            int b = Convert.ToInt32(Console.ReadLine());
            int n = b;
            Console.Write("In baza 16: ");
            int[] v = new int[64];
            char[] alf = { 'A', 'B', 'C', 'D', 'E', 'F' };
            //pentru a determina un caracter in ascii
            //char chr = 'A';
            //int aux = chr;
            //Console.WriteLine(aux);
            if (n == 0)
            {
                v[0] = 0;
                i++;
            }
            while (n > 0)
            {
                v[i] = n % 16;
                n /= 16;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                if (v[j] < 10)
                    Console.Write(v[j]);
                else
                    Console.Write(alf[v[j] - 10]);

            }
            Console.WriteLine();
            Console.Write("In baza 36: ");
            char[] alf2 = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int f = b;
            i = 0;
            if (f == 0)
            {
                alf2[0] = '0';
            }
            while (f > 0)
            {
                v[i] = f % 36;
                f /= 36;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
                Console.Write(alf2[v[j]]);

            //din baza 10 in baza 2.
            int x = b;
            i = 0;
            Console.WriteLine();
            Console.Write("In baza 2 : ");
            if (x == 0)
            {
                v[0] = 0;
                i++;
            }
            while (x > 0)
            {
                v[i] = x % 2;
                x /= 2;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write("{0}", v[j]);
            }
            Console.WriteLine();
            //numarul in baza 8 este
            Console.Write("In baza 8 : ");
            int o = b;
            i = 0;
            if (o == 0)
            {
                v[0] = 0;
                i++;
            }
            while (o > 0)
            {
                v[i] = o % 8;
                o /= 8;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(v[j]);
            }
        }

        private static void p47()
        {
            Console.WriteLine("Pana la ce numar doriti sa se calculeze ?");
            double n = double.Parse(Console.ReadLine()), t = 0;
            //iterativ
            for (int i = 1; i <= n; i++)
                t += i;
            //gauss
            double a = (n * (n + 1)) / 2;
            if(a == t)
            Console.WriteLine("Suma pana la " + n + " este: " + t);
            else
                Console.WriteLine("Oops! Error.");
        }

        private static void p46()
        {
            Console.WriteLine("Introduceti numarul: ");
            double n = double.Parse(Console.ReadLine()), n1 = n;
            Console.WriteLine("Introduceti puterea: ");
            int p = int.Parse(Console.ReadLine());
            while (p > 0)
            {
                n *= n1;
                p--;
            }
            Console.WriteLine("Numarul la puterea ceruta este: {0}", n);
        }

        private static void p45()
        {
            //se dau 2 vectori unul mare si unul mic.
            //sa vedem daca cel de dimensiune mica se regaseste in cel de dimensiune mare.
            //1,2,3,1,5
            //3,1,6
            int[] a = ExtractRandomVector();
            int[] b = ExtractRandomVector();
            //for (int i = 0; i < a.Length; i++)
            //    Console.Write(a[i] + " ");
            //Console.WriteLine();
            //for (int i = 0; i < b.Length; i++)
            //    Console.Write(b[i] + " ");
            Console.WriteLine();
            if (check(a, b) == true)
                Console.WriteLine("Sirul 2 intra in primul.");
            if (check(a, b) == false)
                Console.WriteLine("Sirul 2 nu se gaseste in primul.");
        }
        static bool check(int[] a, int[] b)
        {
            bool ok = false;
            int n1 = a.Length, n2 = b.Length;
            for (int i = 0; i < n1 - n2 + 1; i++)
            {
                if (a[i] == b[0])
                {
                    ok = true;
                    for (int j = 1; j < b.Length; j++)
                        if (a[i + j] != b[j])
                            ok = false;
                    if (ok == true) return ok;
                }
            }
            return ok;
        }
        private static void p44()
        {
            int[] a = ExtractRandomVector();
            List<int> u = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                bool ok = true;
                foreach (var el in u)
                    if (a[i] == el)
                    {
                        ok = false;
                        break;
                    }
                if (ok) u.Add(a[i]);
            }
            //for (int i = 0; i < a.Length; i++)
            //    Console.Write(a[i] + " ");
            //Console.WriteLine();
            for (int i = 0; i < u.Count; i++)
            {
                Console.Write(u[i] + " ");
            }
        }

        private static void p43()
        {
            int[] v = ExtractRandomVector(0,9);
            for (int i = 0; i < v.Length - 1; i++)
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (v[i] > v[j])
                    {
                        int t = v[i];
                        v[i] = v[j];
                        v[j] = t;
                    }
                }
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i] + " ");
            }
        }

        private static void p42()
        {
            int[] v = ExtractVector();
            bool ok;
            do
            {
                ok = true;
                for (int i = 1; i < v.Length; i++)
                    if (v[i - 1] > v[i])
                    {
                        int t = v[i - 1];
                        v[i - 1] = v[i];
                        v[i] = t;
                        ok = false;
                    }
            } while (!ok);
            foreach (var item in v)
                Console.Write(item + " ");
        }

        private static void p41()
        {
            Console.WriteLine("f(x) = x2, x < 3 sau f(x) = x + 1, x >= 3");
            Console.WriteLine("Introduceti x: ");
            int x = ExtractInt();
            if (x < 3)
            {
                int y = x * x;
                Console.WriteLine("f({0}) = {1}", x, y);
            }
            if (x >= 3)
            {
                int y = x + 1;
                Console.WriteLine("f({0}) = {1}", x, y);
            }

        }

        private static void p40()
        {
            //ax2 + bx + c = 0;
            Console.WriteLine("Introduceti a, b si c:");
            int a = ExtractInt();
            int b = ExtractInt();
            int c = ExtractInt();
            float d = b * b - 4 * a * c;
            float x1 = (-b + (float)(Math.Sqrt(d))) / (2 * a);
            float x2 = (-b - (float)(Math.Sqrt(d))) / (2 * a);
            if (d > 0)
            {
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            if (d < 0)
                Console.WriteLine("Ecuatia nu are solutii.");
            if (d == 0)
                Console.WriteLine("x = " + x1);
        }

        private static void p39()
        {
            Stopwatch sw = new Stopwatch();
            int c = 0;
            int t;
            int[] v = ExtractRandomVector(0,9);
            sw.Start();
            for (int i = 0; i < v.Length; i++)
            {
                for (int j = i + 1; j < v.Length; j++)
                {
                    int a = v[j];
                    if (a < v[i])
                    {
                        t = v[i];
                        v[i] = v[j];
                        v[j] = t;
                        c++;
                    }
                    else if (a > v[(v.Length - 1)])
                    {
                        t = v[v.Length - 1 - i];
                        v[v.Length - 1 - i] = v[j];
                        v[j] = t;
                        c++;
                    }
                }
            }

            sw.Stop();
            //foreach (var item in v)
            //    Console.Write(item + " ");
            Console.WriteLine("Executat de " + c + " ori.");
            Console.WriteLine("Timpul de executie este " + sw.Elapsed);
        }

        private static void p38()
        {
            Stopwatch sw = new Stopwatch();
            int max, p, c = 0;
            int[] v = ExtractRandomVector(0,9);
            sw.Start();
            for (int i = 0; i < v.Length - 1; i++)
            {
                max = v[v.Length - 1 - i];
                p = v.Length - 1 - i;
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (max < v[v.Length - 1 - j])
                    {
                        max = v[v.Length - 1 - j];
                        p = v.Length - 1 - i;
                        int t = v[v.Length - 1 - j];
                        v[v.Length - j - 1] = v[p];
                        v[p] = t;
                        c++;
                    }
                }
            }
            sw.Stop();
            //for (int i = 0; i < v.Length; i++)
            //    Console.Write(v[i] + " ");
            Console.WriteLine("Executat de " + c + " ori.");
            Console.WriteLine("Timpul de executie este " + sw.Elapsed);
        }

        private static void p37()
        {
            Stopwatch sw = new Stopwatch();
            int min, p, c = 0;
            int[] v = ExtractRandomVector(0,9);
            sw.Start();
            for (int i = 0; i < v.Length - 1; i++)
            {
                min = v[i];
                p = i;
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (min > v[j])
                    {
                        min = v[j];
                        p = i;
                        int t = v[j];
                        v[j] = v[p];
                        v[p] = t;
                        c++;
                    }
                }
            }
            sw.Stop();
            //for (int i = 0; i < v.Length; i++)
            //Console.Write(v[i] + " ");
            Console.WriteLine("Executat de " + c + " ori.");
            Console.WriteLine("Timpul de executie este " + sw.Elapsed);
        }

        private static void p36()
        {
            Stopwatch sw = new Stopwatch();
            bool ok;
            int[] v = ExtractRandomVector(0,9);
            int k = v.Length - 1;
            int o = 0;
            sw.Start();
            do
            {
                ok = true;
                for (int j = 0; j < k; j++)
                {
                    if (v[j] > v[j + 1])
                    {
                        int t = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = t;
                        ok = false;
                        o++;
                    }
                    //for (int i = 0; i < v.Length; i++)
                    //    Console.Write(v[i] + " ");
                    //Console.WriteLine();
                }
            } while (!ok);
            sw.Stop();
            //for (int i = 0; i < v.Length; i++)
            //    Console.Write(v[i] + " ");
            Console.WriteLine("Executat de " + o + " ori.");
            Console.WriteLine("Timpul de executie este " + sw.Elapsed);
        }

        private static void p35()
        {
            Stopwatch sw = new Stopwatch();
            bool ok;
            int[] v = ExtractRandomVector(0,9);
            int c = 0;
            sw.Start();
            do
            {
                ok = true;
                for (int i = 0; i < v.Length - 1; i++)
                    if (v[i] > v[i + 1])
                    {
                        int t = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = t;
                        ok = false;
                        c++;
                    }
            } while (!ok);
            sw.Stop();
            //for (int i = 0; i < v.Length; i++)
            //Console.Write(v[i] + " ");
            Console.WriteLine("Executat de " + c + " ori.");
            Console.WriteLine("Timpul de executie este " + sw.Elapsed);
        }

        private static void p34()
        {
            int[] v = ExtractVector();
            double norma = 0, suma = 0, produsul = 1;
            for (int i = 0; i < v.Length; i++)
            {
                suma += v[i];
                norma += Math.Pow(v[i], 2);
                produsul *= v[i];
            }
            norma = Math.Sqrt(norma);
            Console.WriteLine("Suma este: " + suma);
            Console.WriteLine("Norma este: " + norma);
            Console.WriteLine("Produsul este: " + produsul);
        }

        private static void p33()
        {
            int[] v = ExtractRandomVector(0,9);
            int[] v2 = new int[v.Length];
            int n = 0;
            for (int i = 0; i < v.Length; i++)
                n = n * 10 + v[i];
            for (int i = 0; i < v.Length; i++)
            {
                v2[i] = n % 10;
                n = n / 10;
            }
            Console.Write("Inversul = ");
            for (int i = 0; i < v2.Length; i++)
                Console.Write(v2[i]);
            Console.WriteLine();
        }

        private static void p32()
        {
            Console.WriteLine("Cate numere introduceti?");
            int min = Int32.MaxValue, n = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti numerele");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} = ", i);
                v[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
                if (min > v[i])
                    min = v[i];
            Console.WriteLine("Minimul este: " + min);

        }

        private static void p31()
        {
            Console.WriteLine("Cate numere introduceti?");
            int n = Convert.ToInt32(Console.ReadLine());
            int c2 = 0, c3 = 0;
            int[] v = new int[n];
            Console.WriteLine("Introduceti numerele");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} = ", i);
                v[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n - 2; i++)
                for (int j = i + 1; j < n - 1; j++)
                    for (int k = j + 1; k < n; k++)
                    {
                        if ((v[i] == v[j]) && (v[j] == v[k]))
                            c3++;
                        if (v[i] == v[j])
                        {
                            c2++;
                            j++;
                        }
                    }
            if (c2 != 0)
                Console.WriteLine("Exista 2 valori identice.");
            if (c3 != 0)
                Console.WriteLine("Exista 3 valori identice.");

        }

        private static void p30()
        {
            Console.WriteLine("Introduceti maxim 4 numere.(Daca sunt mai putine introduceti 0)");
            int[] v = new int[4];
            int min = 0;
            for (int i = 0; i < 4; i++)
                v[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                if ((i == 0) && (v[i] != 0))
                {
                    min = v[i];
                    i++;
                }
                if (min == 0)
                    for (int j = 0; j < 4; j++)
                        if (v[j] != 0)
                        {
                            min = v[j];
                            break;
                        }
                if ((min >= v[i]) && (v[i] != 0)) min = v[i];
            }
            Console.WriteLine("Minimul este : " + min);


        }

        private static void p29()
        {
            Console.Write("Introduceti gradele in Celsius:");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = 1.8 * c + 32;
            Console.WriteLine(f + " Fahrenheit");
        }

        private static void p28()
        {
            Console.Write("a = ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToInt32(Console.ReadLine());
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Aria este: " + s);
        }

        private static void p27()
        {
            Console.WriteLine("Introduceti numarul:");
            ulong n = Convert.ToUInt64(Console.ReadLine()), uc1 = 0, uc2 = 0, nrc = 0, nr = 0, i = 0, ic = 0;
            do
            {
                nrc = n;
                nr = 0;
                i = 0;
                while (n > 0)
                {
                    uc1 = n % 10;
                    n /= 10;
                    uc2 = n % 10;

                    if (nr == 0)
                    {
                        nr = uc1;
                        i++;
                    }
                    if (uc2 > uc1)
                    {
                        nr = nr * 10 + uc2;
                        i++;
                    }
                    if (uc2 <= uc1)
                    {
                        nr = (ulong)Math.Pow(10, i) * uc2 + nr;
                        i++;
                    }
                }
                if (ic == 30) Console.WriteLine(nr);
                n = nr;
                ic++;
            } while (ic <= 30);
        }

        private static void p26()
        {
            int n = Convert.ToInt32(Console.ReadLine()), c = 0, nr = 0;
            int[] v = new int[10];
            while (n > 0)
            {
                c = n % 10;
                v[c]++;
                n /= 10;
            }
            for (int i = 0; i < v.Length; i++)
            {
                while (v[i] > 0)
                {
                    nr = nr * 10 + i;
                    v[i]--;
                }
            }
            Console.WriteLine(nr);
        }

        private static void p25()
        {
            int[] v = new int[15];
            int i = 0, m = 0, n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                v[i] = n % 10;
                n /= 10;
                i++;
            }
            for (i = 0; i < v.Length; i++)
                for (int k = i + 1; k < v.Length; k++)
                    if (v[i] > v[k])
                    {
                        int t = v[i];
                        v[i] = v[k];
                        v[k] = t;
                    }
            for (i = 0; i < v.Length; i++)
                if (v[i] > 0)
                {
                    m = m * 10 + v[i];
                }
            Console.WriteLine(m);
        }

        private static void p24()
        {
            int n, k, m, t, c, r;
            double s = 0;
            n = ExtractInt();
            k = ExtractInt();
            c = n - 1;
            t = n - k;
            r = n - k - 1;
            m = k - 1;

            while (c > 0)
            {
                n = n * c;
                c--;
            }
            while (r > 0)
            {
                t = t * r;
                r--;
            }
            while (m > 0)
            {
                k = k * m;
                m--;
            }

            s = n / (k * t);
            Console.WriteLine("s = {0}", s);
        }

        private static void p23()
        {
            int n, k = 1;
            n = ExtractInt();

            while (n > 0)
            {
                k = k * n;
                n--;
            }
            Console.WriteLine(k);
        }

        private static void p22()
        {
            int n, k, t, c, r;
            double s = 0;
            n = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            c = n - 1;
            t = n - k;
            r = k - 1;

            while (c > 0)
            {
                n = n * c;
                c--;
            }
            while (r > 0)
            {
                t = t * r;
                r--;
            }
            s = n / t;
            Console.WriteLine("s = {0}", s);

        }

        private static void p21()
        {
            int n = ExtractInt(), aux;
            int[] v = new int[n];
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (v[i] > v[j])
                    {
                        aux = v[j];
                        v[j] = v[i];
                        v[i] = aux;
                    }
                }
                Console.Write(v[i]);
            }
        }

        private static void p20()
        {
            int ic, c, n = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 1; i <= n; i++)
            {
                ic = 1; c = 1;
                while (c <= i)
                {
                    ic = 1;
                    while (ic <= i)
                    {
                        Console.Write(c + ",");
                        ic++;
                    }
                    c++;
                }

            }
        }

        private static void p19()
        {
            Console.WriteLine("Introduceti textul sursa:");
            string TextSursa = Console.ReadLine();
            Console.WriteLine("Introduceti textul cautat");
            string TextCautat = Console.ReadLine();
            bool ok = false;
            int i, j;
            for (i = 0; i <= TextSursa.Length - TextCautat.Length; i++)
            {
                for (j = 0; j < TextCautat.Length; j++)
                    if (TextSursa[i + j] != TextCautat[j])
                        break;
                if (j == TextCautat.Length)
                {
                    ok = true;
                    break;
                }
            }
            if (ok)
                Console.WriteLine("Textul cautat se regaseste in cel sursa incepand cu pozitia {0}.", i + 1);
            else
                Console.WriteLine("Textul cautat nu se regaseste in cel sursa.");
        }

        private static void p18()
        {
            string text1 = Console.ReadLine();
            char[] text = text1.ToCharArray();
            bool FirstWord = true;
            char[] Tokens = { '.', '?', '!' };
            for (int i = 0; i < text.Length; i++)
            {
                if (!FirstWord)
                {
                    if (text[i] == '.' || text[i] == '?' || text[i] == '!')
                    {
                        FirstWord = true;
                        if (FirstWord)
                            Console.Write("{0}", text[i]);
                        i++;
                    }
                    else
                        if (char.IsLetter(text[i]))
                        Console.Write(text[i]);
                    if (!char.IsLetter(text[i]))
                        Console.Write(text[i]);
                }
                if (FirstWord)
                {
                    if (char.IsLetter(text[i]))
                    {
                        Console.Write(text[i].ToString().ToUpper());
                        FirstWord = false;
                    }
                    if (text[i] == '.' || text[i] == '?' || text[i] == '!')
                    {
                        FirstWord = true;
                        if (FirstWord)
                            Console.Write("{0}", text[i]);
                    }
                }
            }
        }

        private static void p17()
        {
            string text = Console.ReadLine();
            bool InWord = false;
            int i = 0;
            char[] tokens = { '.', '?', '!', ',', ';' };
            while (i < text.Length)
            {
                for (int j = 0; j < tokens.Length; j++)
                {
                    if (text[i] == tokens[j])
                        Console.Write(tokens[j]);
                }
                if (InWord)
                    if (char.IsLetter(text[i]))
                        Console.Write(text[i]);
                    else
                    {
                        InWord = false;
                    }
                else
                    if (char.IsLetter(text[i]))
                {
                    InWord = true;
                    Console.Write(text[i].ToString().ToUpper());
                }
                i++;
            }
        }

        private static void p16()
        {
            string text = Console.ReadLine();
            bool InWord = false;
            int i = 0, nr = 0;
            while (i < text.Length)
            {
                if (InWord)
                    if (char.IsLetter(text[i]))
                        Console.Write(text[i]);
                    else
                    {
                        InWord = false;
                        Console.WriteLine();
                    }
                else
                    if (char.IsLetter(text[i]))
                {
                    InWord = true;
                    Console.Write(text[i]);
                    nr++;
                }
                i++;
            }
            if (InWord)
                Console.WriteLine();
            Console.WriteLine("In text sunt {0} cuvinte.", nr);

        }

        private static void p15()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int c = 1, p = 0;
            do
            {
                p = 0;
                c++;
                while (n % c == 0)
                {
                    p++;
                    n /= c;
                }
                if (n == 1)
                    Console.Write("{0}^{1}", c, p);
                else
                {
                    if (p > 0)
                        Console.Write("{0}^{1}*", c, p);
                }
            } while (n != 1);
        }

        private static void p14()
        {
            string c = Console.ReadLine();
            char[] v = c.ToCharArray();
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i].ToString().ToUpper());
            }
        }

        private static void p13()
        {
            int c = Convert.ToChar(Console.ReadLine()) - 32;
            char aux = (char)c;
            Console.WriteLine(aux);
        }

        private static void p12()
        {
            Console.Write("Introduceti caracterul: ");
            char c = Convert.ToChar(Console.ReadLine());
            int v = c;
            Console.WriteLine("Valoarea caracterului {0} in ASCII este {1}.", c, v);
        }

        private static void p11()
        {
            int d = ExtractInt(), i = 0, n = d;
            Console.Write("In baza 8 : ");
            int[] b = new int[31];
            //baza 8;
            if (n == 0)
            {
                b[0] = 0;
            }
            while (n > 0)
            {
                b[i] = n % 8;
                n /= 8;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write("{0}", b[j]);
            }
            //baza 16
            Console.WriteLine();
            Console.Write("In baza 16: ");
            char[] alf = { 'A', 'B', 'C', 'D', 'E', 'F' };
            i = 0;
            int a = d;
            if (a == 0)
            {
                b[0] = 0;
            }
            while (a > 0)
            {
                b[i] = a % 16;
                a /= 16;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                if (b[j] < 10)
                    Console.Write(b[j]);
                else
                    Console.Write(alf[b[j] - 10]);
            }




        }

        private static void p10()
        {
            //varianta 1.
            Console.WriteLine("H");
            Console.WriteLine("e");
            Console.WriteLine("l");
            Console.WriteLine("l");
            Console.WriteLine("o");
            Console.WriteLine(" ");
            Console.WriteLine("W");
            Console.WriteLine("o");
            Console.WriteLine("r");
            Console.WriteLine("l");
            Console.WriteLine("d");
            Console.WriteLine("!");
            Console.WriteLine("!");

            //varianta 2 vector.
            string v = "Hello World!!";

            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }
        }

        private static void p9()
        {
            int n = ExtractInt();
            int nc = 0, suma = 0, fin = n;

            while (n > 0)
            {
                nc = n % 10;
                n = n / 10;
                suma = suma + nc;
            }
            Console.WriteLine("Suma cifrelor numarului {0} este {1}", fin, suma);
        }

        private static void p8()
        {
            Console.WriteLine("Introduceti numarul numerelor:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti numerele:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Numarul {0} = ", i);
                v[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (max < v[i])
                {
                    max = v[i];
                }
            }
            Console.WriteLine("Cel mai mare numar este {0}.", max);
        }

        private static void p7()
        {
            int n = ExtractInt();
            int nc = n, ncc = 0;

            while (nc > 0)
            {
                ncc = ncc * 10 + nc % 10;
                nc = nc / 10;
            }
            if (n == ncc)
                Console.WriteLine("Numarul este palindrom");
            else
                Console.WriteLine("Numarul nu este palindrom");
        }

        private static void p6()
        {
            int n = ExtractInt();
            int d = 2, c = 0;

            do
            {
                if (n % d == 0)
                {
                    c++;
                }
                d++;
            } while ((c == 0) && (d * d <= 0));

            if (c == 0)
                Console.WriteLine("{0} este prim", n);
            else
                Console.WriteLine("{0} nu este prim", n);
        }

        private static void p5()
        {
            uint n = 12345u;
            //base2(n);

            base2Reverse(n);

            if (isBitSet(n, 7))
                Console.WriteLine("bitul de pe pozitia 7 este setat");
            else
                Console.WriteLine("bitul de pe pozitia 7 nu este setat");
            //Console.WriteLine("Bitul de pe pozitia 7 {0}este setat.",isbBtSet(n, 7 ?"":"nu "));

            BitSet(n, 7);

            //reset: oricat ar fi bitul de pe poz 7 il face 0;
            bitReset(ref n, 7);

            uint m = 123456, k = 654321, c;
            c = m ^ k;
            Console.WriteLine("c = {0}", c);

            m = c ^ k;
            Console.WriteLine("m = {0}", m);
        }

        private static void bitReset(ref uint n, int v)
        {
            //exemplu 000001010000100000010100
            //11111101111111111111

            n = n & (~(1u << v));
        }

        private static void BitSet(uint n, int v)
        {
            //
            n = n | (1u << v);
        }

        private static bool isBitSet(uint n, int v)
        {
            // sau=> n &(1u << v)
            if (((n >> v) & 1u) != 0)
                return true;
            else
                return false;

        }

        private static void base2(int n)
        {
            for (int i = 0; i < 32; i++)
            {

            }
        }

        private static void base2Reverse(uint n)
        {
            while (n > 0)
            {
                //exemplu
                //000001110000...10010100000
                //0000000000...0000000000001
                Console.Write(n & 1u);
                n = n >> 1;
            }
            Console.WriteLine();
        }

        private static void P4()
        {
            int p, a = 0, b = 1, x, i;
            Console.WriteLine("Introduceti Pozitia: ");
            p = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[p];
            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (a == 0 && b == 1)
            {

                for (i = 0; i < v.Length; i++)
                {
                    x = a + b;
                    a = b;
                    b = x;
                }
            }
            sw.Stop();
            if (p == 0) Console.WriteLine("Numarul de pe pozitia {0} este: {1}", p, a);
            else Console.WriteLine("Numarul de pe pozitia {0} este: {1}", p, b);
            Console.WriteLine("Elapsed Time: {0}", sw.Elapsed);

        }

        private static void P3()
        {
            bool ok = true;//fals secventa creste, true scade.
            int a, b;

            a = ExtractInt();
            if (a != 0)
            {
                do
                {
                    b = ExtractInt();
                    if (b != 0)
                    {
                        if (a > b)
                        {
                            ok = false;
                            a = b;
                        }
                    }

                }
                while (b != 0);
            }

            if (a == 0)
            {
                Console.WriteLine("Secventa nu exista.");
            }
            if (false && a != 0)
            {
                Console.WriteLine("Secventa este crescatoare");
            }
            if (true && a != 0)
            {
                Console.WriteLine("Secventa nu este crescatoare");
            }
            Console.ReadKey();
        }

        private static void P2()
        {
            int n, max = int.MinValue;

            do
            {
                n = ExtractInt();
                if (n != 0)
                {
                    if (n > 0)
                    {
                        max = n;
                    }
                }
            }
            while (n != 0);
            Console.WriteLine("cel mai mare numar este {0}", max);
            Console.ReadKey();
        }

        private static void P1()
        {
            int n, suma = 0;
            do
            {
                n = ExtractInt();
                if (n != 0)
                {
                    suma = suma + n;
                }
            }
            while (n != 0);
            Console.WriteLine("{0}", suma);
            Console.ReadKey();
        }
        private static int ExtractInt()
        {
            Console.WriteLine("Introduceti numarul:");
            string line = Console.ReadLine();
            int n = 0;

            try
            {
                n = Int32.Parse(line);
            }
            catch (Exception)
            {
                Console.WriteLine("OOps something went wrong...that's embarasing!!");
            }
            return n;
        }
        private static int[] ExtractVector()
        {
            Console.WriteLine("Cate numere introduceti?");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti numerele");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} = ", i);
                v[i] = Convert.ToInt32(Console.ReadLine());
            }
            return v;
        }
        private static int[] ExtractRandomVector(int x, int y)
        {
            Console.WriteLine("Cate numere introduceti?");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                v[i] = r.Next(x,y);
            return v;
        }
        private static int[] ExtractRandomVector()
        {
            Console.WriteLine("Cate numere introduceti?");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
                v[i] = r.Next(10);
            return v;
        }
        private static List<int> ExtractList()
        {
            Console.WriteLine("Cate numere introduceti?");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> v = new List<int>(n);
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} = ", i);
                v[i] = Convert.ToInt32(Console.ReadLine());
            }
            return v;
        }
        private static List<int> ExtractRandomList()
        {
            Console.WriteLine("Cate numere introduceti?");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> v = new List<int>(n);
            Random r = new Random();
            for (int i = 0; i < n; i++)
                v[i] = r.Next(10);

            return v;
        }
        private static List<int> ExtractRandomList(int x, int y)
        {
            Console.WriteLine("Cate numere introduceti?");
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> v = new List<int>(n);
            Random r = new Random();
            for (int i = 0; i < n; i++)
                v[i] = r.Next(x,y);

            return v;
        }
    }
}

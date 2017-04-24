using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemeAlgoritmi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Probelma1 - ??
            //Problema2();
            //Problema3();
            //Problema4C();
            //Problema4D();
            //Problema5();
            //Problema6();
            //Problema7();
            //Problema8();
            //Problema9();
            //Problema10 - ??
            //Problema11();
            //Problema12();
            //Problema13();
            //Problema14();
            //Problema15();
            //Problema16();
            //Problema17();
            //Problema18();
            //Problema19();
            //Problema20();
            //Problema21();
            //Problema22();
            //Problema23();
            //Problema24(); ???
            //Problema25();
            //Problema26();
            //Problema27(); ???
            //Problema28();
            //Problema29();
            //Problema30(); ???
            //Problema31(); ???
            //Problema32(); ???
            //Problema33();
            //Problema34();
            //Problema35();
            //Problema36();
            //Problema37();
            //Problema38(); ???
            //Problema39(); ???
            //Problema40(); ???
            //Problema41(); ???
            //Problema42(); ???
            //Problema43(); ???
            //Problema44();
            //Problema45();
            Console.ReadKey();
            
        }

        private static void Problema45()
        {
            //Ridicarea la putere a unui numar
            Console.Write("baza = ");
            long baza = long.Parse(Console.ReadLine());
            Console.Write("exponent = ");
            int exponent = int.Parse(Console.ReadLine());
            long val;
            val = pow(baza, exponent);
            Console.WriteLine(val);
        }

        private static long pow(long baza, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }
            else
            {
                if (exponent == 1)
                {
                    return baza;
                }
                else
                {
                    if (exponent % 2 == 0)
                    {
                        return pow(baza, (exponent - 1) / 2) * pow(baza, (exponent - 1) / 2) * baza * baza;
                    }
                    else
                    {
                        return pow(baza, (exponent - 1) / 2) * pow(baza, (exponent - 1) / 2) * baza;
                    }
                }
            }
        }

        private static void Problema44()
        {
            //Cautarea binara
            int[] v = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.Write("Introduceti elementul cautat: ");
            int x = int.Parse(Console.ReadLine());
            int n = v.Length;
            bool b = cb(v, x, 0, n - 1);
            if (b == true)
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NU");
            }

        }

        private static bool cb(int[] v, int x, int s, int d)
        {
            if (s <= d)
            {
                int m = (s + d) / 2;
                if (x < v[m])
                {
                    return cb(v, x, s, (s + d) / 2 - 1);
                }
                else
                {
                    if (x > v[m])
                    {
                        return cb(v, x, (s + d) / 2 + 1, d);
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }
        }

        private static void Problema43()
        {
            
        }

        private static void Problema42()
        {
            
        }

        private static void Problema41()
        {
            
        }

        private static void Problema40()
        {
            
        }

        private static void Problema39()
        {
            
        }

        private static void Problema38()
        {
            
        }


//static int n = 5;
//static int[,] a = new int[n, n];
//static bool[,] b = new bool[n, n];
//static int[] v = new int[3];
//static int d = 0;


        private static void Problema37()
        {
            /*
            Problema teritoriilor(valori 0 adiacente inconjurate de aceeasi valoare - Jocul GO)
            Se da o matrice de valori 0, 1, 2. Se defineste teritoriul lui 1, un platou(definit
            ca in problema 36) de valoare 0, pentru care toti vecinii sunt 1; analog teritoriul
            lui 2 este un platou de valoare 0 pentru care toti vecinii au valoarea 2. Pentru o
            matrice data contorizati elementele constitutive ale teritoriilor lui 1 si 2.
            */
            int nrv1 = 0;
            int nrv2 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = false;
                }
            }
            TextReader dl = new StreamReader(@"../../Resurse/matrice.txt");
            string t = dl.ReadLine();
            string[] p;
            int l = 0, c = 0;
            while (t != null)
            {
                p = t.Split(' ');
                foreach (var item in p)
                {
                    if (c < n)
                    {
                        a[l, c] = int.Parse(item);
                        c++;
                    }
                }
                l++;
                c = 0;
                t = dl.ReadLine();
            }
            dl.Close();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();

                //for (int i = 0; i < n; i++)
                //{
                //    for (int j = 0; j < n; j++)
                //    {
                //        v[1] = 0;
                //        v[2] = 0;
                //        d = 0;
                //        rec(i, j);
                //        if (v[1] != 0 && v[2] == 0)
                //        {
                //            nrv1 += d;
                //        }
                //        else
                //        {
                //            if (v[1] == 0 && v[2] != 0)
                //            {
                //                nrv2 += d;
                //            }
                //        }
                //    }
                //}
                Console.WriteLine("Numarul teritoriilor lui 1 este {0} iar numarul teritoriilor lui 2 este {1}", nrv1, nrv2);
            }
        }


        public static int n = int.Parse(Console.ReadLine());
        public static int[,] a = new int[n, n];
        public static bool[,] b = new bool[n, n];
        public static int val, d;

        private static void Problema36()
        {
            Random r = new Random();
            /*Problema platourilor de altitudine maximala intr-o matrice de valori intregi. 
            Se da o matrice de valori intregi. Se defineste un platou ca si o secventa
            de elemente din matrice, adiacente(N, V, S, E), de aceeasi valoare. Pentru o
            matrice data sa se determine prin afisarea elementelor constitutive, cel mai larg platou.          
            */
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    b[i, j] = false;

            //TextReader dl = new StreamReader(@"../../Resurse/matrice.txt");
            //string t = dl.ReadLine();
            //string[] p;
            //int l = 0, c = 0;
            //while (t != null)
            //{
            //    p = t.Split(' ');
            //    foreach (var item in p)
            //    {
            //        if (c < n)
            //        {
            //            a[l, c] = int.Parse(item);
            //            c++;
            //        }
            //    }
            //    l++;
            //    c = 0;
            //    t = dl.ReadLine();            
            //}
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = r.Next(4);
                }

            //dl.Close();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            int max = 0;
            int cifra_finala = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    val = a[i, j];
                    d = 0;
                    rec(i, j);
                    if (d >= max)
                    {
                        max = d;
                        cifra_finala = val;
                    }
                }

            Console.WriteLine("Lungimea maxima a platoului este {0}, formata din cifra {1}", max, cifra_finala);
        }

        public static void rec(int i, int j)
        {
            if ((i>=0) && (i < n) && (j >= 0) && (j < n) && (b[i, j] == false) && a[i, j] == val)
            {
                b[i, j] = true;
                d++;
                rec(i + 1, j);
                rec(i - 1, j);
                rec(i, j + 1);
                rec(i, j - 1);
            }
        }

        private static void Problema35()
        {
            //Algoritmul de sortare Merge Sort
            Console.Write("Introduceti numarul de elemente al vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti elementele vectorului: ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("v[{0}] = ", i);
                v[i] = int.Parse(Console.ReadLine());
            }
            int[] c = merge(v, 0, n - 1);
            foreach (var item in c)
            {
                Console.WriteLine(item + " ");
            }
        }
        private static int[] merge(int[] v, int s, int d)
        {
            if (s < d)
            {
                int[] v1 = merge(v, s, (s + d) / 2);
                int[] v2 = merge(v, (s + d) / 2 + 1, d);
                return interclasare(v1, v2);                
            }
            return new int[] { v[s] };
        }
        private static int[] interclasare(int[] v1, int[] v2)
        {
            int k1 = 0, k2 = 0, k3 = 0;
            int n1 = v1.Length;
            int n2 = v2.Length;
            int[] v3 = new int[n1 + n2];
            do
            {
                if (v1[k1] < v2[k2])
                {
                    v3[k3] = v1[k1];
                    k1++;
                    k3++;
                }
                else
                {
                    v3[k3] = v2[k2];
                    k2++;
                    k3++;
                }
            } while (k1 < n1 && k2 < n2);
            while (k1 < n1)
            {
                v3[k3] = v1[k1];
                k1++;
                k3++;
            }
            while (k2 < n2)
            {
                v3[k3] = v2[k2];
                k2++;
                k3++;
            }
            return v3;

        }
	

	

        private static void Problema34()
        {
            /*Implementarea algoritmului pentru rezolvarea problemei Turnurile din Hanoi cu 4 tije.
            Analog cu enuntul problemei 33 cu specificatia ca exista 2 tije intermediare.
            */
            Console.Write("Introduceti numarul de discuri: ");
            int n = int.Parse(Console.ReadLine());
            Hanoi4(n, "A", "B", "C", "D");
        }

        private static void Hanoi4(int n, string A, string B, string C, string D)
        {
            if (n == 1)
            {
                Console.WriteLine("{0} -> {1}", A, D);
            }
            else
            {
                if (n == 2)
                {
                    Console.WriteLine("{0} -> {1}", A, B);
                    Console.WriteLine("{0} -> {1}", A, D);
                    Console.WriteLine("{0} -> {1}", B, D);
                }
                else
                {
                    Hanoi4(n - 2, A, C, D, B);
                    Hanoi4(2, A, C, B, D);
                    Hanoi4(n - 2, B, A, C, D);
                }
            }
        }

        private static void Problema33()
        {
            /*Implementarea algoritmului pentru rezolvarea problemei Turnurile din Hanoi cu 3 tije
            Aceasta problema presupune existenta unui set n de discuri de diferite marimi, asezate in
            ordine descrescatoare pe o tija numita sursa(discul cu circumferinta cea mai mare se gaseste cel 
            mai jos). Exista de asemenea inca doua tije numite intermediar si destinatie. Obiectivul problemei
            consta in mutarea celor n discuri de pe tija sursa pe tija destinatie folosind tija intermediar cu
            urmatoarele trei restrictii: 1.Se poate muta o data o singura piesa de pe o anumita tija(cea mai de sus);
            2.Nu se poate pune un disc de dimensiune mai mare peste un disc de dimensiune mai mica.
            3.Numarul de mutari trebuie sa fie minim.
            */
            Console.Write("Introduceti numarul de discuri: ");
            int n = int.Parse(Console.ReadLine());
            Hanoi3(n, "A", "B", "C"); //de pe A pe C
        }

        private static void Hanoi3(int n, string A, string B, string C)
        {
            if (n == 1)
            {
                Console.WriteLine("{0} -> {1}", A, C);
            }
            else
            {
                Hanoi3(n - 1, A, C, B);
                Hanoi3(1, A, B, C);
                Hanoi3(n - 1, B, A, C);
            }
        }

        private static void Problema32()
        {
            //Construirea fractalului lui Sierpinski
        }

        private static void Problema31()
        {
            //Construirea fractalului lui Koch(fulg de nea)
        }

        private static void Problema30()
        {
            //Implementarea notiunilor elementare de grafica si construirea fractalului lui Cantor
        }

        private static void Problema29()
        {
            //Sirul lui Fibonacci
            int i, n;
            Console.Write("Introduceti n: ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                Console.WriteLine(fibonacci(i));
            }
            Console.ReadKey();
        }

        private static int fibonacci(int i)
        {
            if (i < 2)
            {
                return i;
            }
            else
            {
                return fibonacci(i - 1) + fibonacci(i - 2);
            }
        }

        private static void Problema28()
        {
            //Functia factorial
            long n = long.Parse(Console.ReadLine());
            long f = facorial(n);
            Console.WriteLine(f.ToString());
        }

        private static long facorial(long n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * facorial(n - 1);
            }
        }

        private static void Problema27()
        {
            //Incluziunea a doua matrici
        }

        private static void Problema26()
        {

            //Produsul a doua matrici
            Console.Write("Numarul de linii al celor doua matrici este: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Numarul de coloane al celor doua matrici este: ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];
            int[,] b = new int[m, n];
            int[,] produs = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0}, {1}] = ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("b[{0}, {1}] = ", i, j);
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    produs[i, j] = a[i, j] + b[i, j];
                    Console.Write(produs[i, j] + " ");
                }
            }

        }

        private static void Problema25()
        {
            //Suma a doua matrici
            Console.Write("Numarul de linii al celor doua matrici este: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Numarul de coloane al celor doua matrice este: ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];
            int[,] b = new int[m, n];
            int[,] suma = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0}, {1}] = ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("b[{0}, {1}] = ", i, j);
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    suma[i, j] = a[i, j] + b[i, j];
                    Console.Write(suma[i, j] + " ");
                }
            }

            
        }

        

        private static void Problema24()
        {
            //Parcurgerea in spirala a unei matrici
            
            

       
        
            
        }
    

    private static void Problema23()
        {
            //Identificarea zonelor din matrice(de o parte si de alta a diagonalei principale si secundare)
            Console.Write("Dati ordinul matricei patratice: ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("a[{0}, {1}] = ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int urma = 0;
            for (i = 0; i < n; i++)
            {
                urma = urma + a[i, i];
            }
            Console.WriteLine(urma);

        }

        private static void Problema22()
        {
            Console.Write("Numarul de linii al matricei este: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Numarul de coloane al matricei este: ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];
            int i, j;
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("a[{0}, {1}]", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            int d = a[0, 0] * a[1, 1] * a[2, 2] + a[1, 0] * a[2, 1] * a[0, 2] + a[2, 0] * a[0, 1] * a[1, 2] - a[0, 2] * a[1, 1] * a[2, 0] - a[1, 2] * a[2, 1] * a[0, 0] - a[2, 2] * a[0, 1] * a[1, 0];
            Console.WriteLine(d);
            
        }

        private static void Problema21()
        {
            //Produsul a doua numere reprezentate ca vectori de cifre
            Console.WriteLine("Introduceti numarul de elemente din primul vector: ");
            int n = int.Parse(Console.ReadLine());
            int[] v1 = new int[n];
            Console.WriteLine("Introduceti elementele primului vector: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("v[{0}] = ", i);
                v1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Introduceti numarul de elemente din cel de-al doilea vector: ");
            int m = int.Parse(Console.ReadLine());
            int[] v2 = new int[m];
            Console.WriteLine("Introduceti elementele celui de-al doilea vector: ");
            for (int i = 0; i < m; i++)
            {
                Console.Write("v[{0}] = ", i);
                v2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine(v1[i] * v2[i]);
                }
            }
        }

        private static void Problema20()
        {
            //Adunarea a doua numere reprezentate ca si vectori de cifre
            Console.WriteLine("Introduceti numarul de elemente din primul vector: ");
            int n = int.Parse(Console.ReadLine());
            int[] v1 = new int[n];
            Console.WriteLine("Introduceti elementele primului vector: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("v1[{0}] = ", i);
                v1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Introduceti numarul de elemente din cel de-al doilea vector: ");
            int m = int.Parse(Console.ReadLine());
            int[] v2 = new int[m];
            
            Console.WriteLine("Introduceti elementele celui de-al doilea vector: ");
            for (int i = 0; i < m; i++)
            {
                Console.Write("v2[{0}] = ", i);
                v2[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine(v1[i] + v2[j]);
                }
            }
        }

        private static void Problema19()
        {
            //Algoritm de determinare daca un vector de dimensiune mai mica se regaseste intr-unul mai mare
            Console.WriteLine("Introduceti numarul de elemente din primul vector: ");
            int n = int.Parse(Console.ReadLine());
            int[] v1 = new int[n];
            Console.WriteLine("Introduceti elementele primului vector: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("v[{0}] = ", i);
                v1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Introduceti numarul de elemente din cel de-al doilea vector: ");
            int m = int.Parse(Console.ReadLine());
            int[] v2 = new int[m];
            Console.WriteLine("Introduceti elementele celui de-al doilea vector: ");
            for (int i = 0; i < m; i++)
            {
                Console.Write("v[{0}] = ", i);
                v2[i] = int.Parse(Console.ReadLine());
            }
            bool isSubset = v2.All(elem => v1.Contains(elem));
            isSubset = true;
            foreach (var elem in v2)
            {
                if (!v1.Contains(elem))
                {
                    isSubset = false;
                    break;
                }
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

        private static void Problema18()
        {
            //Diferenta elementelor a doi vectori
            int n, m;
            bool exist, empty = true;
            int pos = 0;
            Console.WriteLine("Introduceti numarul de elemente din primul vector: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul de elemente din cel de-al doilea vector: ");
            m = int.Parse(Console.ReadLine());
            float[] v1 = new float[n];
            float[] v2 = new float[m];
            float[] dif = new float[n];

            Console.WriteLine("Introduceti elementele primului vector: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("v1[{0}] = ", i);
                v1[i] = float.Parse(Console.ReadLine()); 
            }
            Console.WriteLine("Introduceti elementele celui de-al doilea vector: ");
            for (int i = 0; i < m; i++)
            {
                Console.Write("v2[{0}] = ", i);
                v2[i] = float.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                exist = false;
                for (int j = 0; j < m; j++)
                {
                    if (v1[i] == v2[j])
                    {
                        exist = true;
                        break;
                    }
                    
                }
                if (exist == false)
                {
                    dif[pos] = v1[i];
                    pos++;
                    empty = false;
                        
                }
            }
            Console.Write("v1 \\ v2 = ");
            if (empty == false)
            {
                for (int i = 0; i < pos; i++)
                {
                    Console.Write("{0} ", dif[i]);
                }

            }
            else
            {
                Console.Write("Multimea vida");
            }
        }

        private static void Problema17()
        {
            //Intersectia a doi vectori
            int n, m, pos = 0;
            bool empty = true;
            Console.WriteLine("Introduceti numarul de elemente din primul vector: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul de elemente din cel de-al doilea vector: ");
            m = int.Parse(Console.ReadLine());
            float[] v1 = new float[n];
            float[] v2 = new float[m];
            Console.WriteLine("Introduceti elementele primului vector: ");
            for (int i = 0; i < v1.Length; i++)
            {
                Console.Write("v[{0}] = ", i);
                v1[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Introduceti elementele celui de-al doilea vector: ");
            for (int i = 0; i < v2.Length; i++)
            {
                Console.Write("v[{0}] = ", i);
                v2[i] = float.Parse(Console.ReadLine());
            }

            int p = Math.Min(n, m);
            float[] intersectie = new float[p];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (v1[i] == v2[j])
                    {
                        intersectie[pos] = v1[i];
                        pos++;
                        empty = false;
                    }
                }
            }
            Console.WriteLine("Rezultatul intersectiei: ");
            if (empty)
            {
                Console.WriteLine("Multimea vida");
            }
            else
            {
                for (int i = 0; i < pos; i++)
                {
                    Console.WriteLine("{0}", intersectie[i]);
                }
            }
        }

        private static void Problema16()
        {
            //Reuniunea a doi vectori
            int n;
            int m;
            Console.WriteLine("Introduceti numarul de elemente din primul vector: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul de elemente din cel de-al doilea vector: ");
            m = int.Parse(Console.ReadLine());
            float[] v1 = new float[n];
            float[] v2 = new float[m];
            Console.WriteLine("Introduceti elementele primului vector: ");
            for (int i = 0; i < v1.Length; i++)
            {
                Console.Write("v[{0}] = ", i);
                v1[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Introduceti elementele celui de-al doilea vector: ");
            for (int i = 0; i < v2.Length; i++)
            {
                Console.Write("v[{0}] = ", i);
                v2[i] = float.Parse(Console.ReadLine());
            }

            int pos = n;
            bool find;
            for (int j = 0; j < v2.Length; j++)
            {
                find = false;
                for (int i = 0; i < v1.Length; i++)
                {
                    if (v2[j] == v2[i])
                    {
                        find = true;
                        break;
                    }
                }
                    if (!find)
                    {
                        v1[pos] = v2[j];
                        pos++;
                    }
            }

            Console.WriteLine("Rezultatul reuniunii: ");
            n = pos;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", v1[i]);
            }
        }

        private static void Problema15()
        {
            //Concatenarea a doi vectori
            Console.WriteLine("Introduceti numarul de elemente al primului vector: ");
            int n = int.Parse(Console.ReadLine());
            int[] v1 = new int[n];
            Console.WriteLine("Introduceti elementele primului vector: ");
            for (int i = 0; i < v1.Length; i++)
            {
                Console.Write("v1[{0}] = ", i);
                v1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Introduceti numarul de elemente al celui de-al doilea vector: ");
            int m = int.Parse(Console.ReadLine());
            int[] v2 = new int[m];
            Console.WriteLine("Introduceti elementele celui de-al doilea vector: ");
            for (int i = 0; i < v2.Length; i++)
            {
                Console.Write("v2[{0}] = ", i);
                v2[i] = int.Parse(Console.ReadLine());
            }
            var result = v1.Concat(v2);
            Console.Write("Result: ");
            foreach (var number in result)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }


        private static void Problema14()
        {
            //Algoritmul de sortare prin insertie
            Console.WriteLine("Introduceti numarul de elemente al vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti elementele vectorului: ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("v[{0}] = ", i);
                v[i] = int.Parse(Console.ReadLine());
            }

            insertie(v);
            afisare_(v);
            Console.ReadKey();
        }

        private static void afisare_(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine("v[{0}] = {1}", i, v[i]);
            }
        }

        private static void insertie(int[] v)
        {
            int i, j, aux;
            for (i = 1; i < v.Length; i++)
            {
                if (v[i] < v[i -1])
                {
                    aux = v[i];
                    j = i - 1;
                    while (j >= 0 && v[j] > aux)
                    {
                        v[j + 1] = v[j];
                        j--;
                    }
                    v[j + 1] = aux;
                }
            }
        }

        private static void Problema13()
        {
            //Algoritmul de sortare prin selectie directa
            Console.WriteLine("Introduceti numarul de elemente al vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < v.Length; i++)
            { 
                Console.Write("v[{0}] = ", i);
                v[i] = int.Parse(Console.ReadLine());
            }

            selectied(v);
            afisare(v);
        }

        private static void afisare(int[]v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine("v[{0}] = {1}", i, v[i]);
            }
        }

        private static void selectied(int[]v)
        {
            int i, j;
            int poz;
            for (i = 0; i < v.Length - 1; i++)
            {
                poz = i;
                for (j = i + 1; j < v.Length; j++)
                {
                    if (v[poz] > v[j])
                    {
                        poz = j;
                    }
                    int t = v[i];
                    v[i] = v[poz];
                    v[poz] = t;
                }
            }
        }

        private static void Problema12()
        {
            //Algortimul de sortare Selection Sort
            Console.WriteLine("Introduceti numarul de elemente al vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti elementele vectorului: ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("v[{0}] = ", i);
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < v.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (v[min] < v[j])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int t = v[i];
                    v[i] = v[min];
                    v[min] = t;
                }
            }
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }


        }

        private static void Problema11()
        {
            //Algoritmul de sortare Bubble Sort
            bool ok;
            int temp = 0;
            Console.WriteLine("Introduceti numarul de elemente al vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti elementele vectorului: ");
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write("v[{0}] = ", i);
                v[i] = int.Parse(Console.ReadLine());
            }
            do
            {
                int k = 0;
                ok = true;
                for (int i = 0; i < n - 1 - k; i++)
                {
                    if (v[i] > v[i + 1])
                    {
                        int t = v[i];
                        v[i] = v[i + 1];
                        v[i + 1] = t;
                        ok = false;
                        k++;
                    }
                }
            } while (!ok);
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i] + " ");
            }
        }

        private static void Problema9()
        {
            //Minimul/Maximul elementelor unui vector
            int min = int.MaxValue;
            int max = int.MinValue;
            Console.WriteLine("Introduceti numarul de elemente al vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Introduceti elementele vectorului: ");
            for (int i = 0; i < v.Length; i++)
            {
               
                Console.Write("v[{0}] = ", i);
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < v.Length; i++)
            {
                if (max < v[i])
                {
                    max = v[i];
                }
                if (min > v[i])
                {
                    min = v[i];
                }
            }
            Console.WriteLine("Minimul elementelor vectorului este {0}", min);
            Console.WriteLine("Maximul elementelor vectorului este {0}", max);
            

            
        }

        private static void Problema8()
        {
            //Suma/ produsul/ norma elementelor unui vector
            Console.Write("Introduceti numarul de elemente al vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int s = 0;
            int p = 1;
            double nor = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i]);
                v[i] = int.Parse(Console.ReadLine());
                s = s + v[i];
                p = p * v[i];
                nor = nor + Math.Pow(v[i], 2);
            }
            Console.WriteLine("Suma elementelor vectorului este {0}", s);
            Console.WriteLine("Produsul elementelor vectorului este {0}", p);
            nor = Math.Sqrt(nor);
            Console.WriteLine("Norma elementelor vectorului este {0}", nor);
        }

        private static void Problema7()
        {
            //Algoritmul lui Euclid
            Console.WriteLine("Introduceti numerele: ");
             int a = int.Parse(Console.ReadLine());
             int b = int.Parse(Console.ReadLine());
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            if (a == 0)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a);
            }
        }

        private static void Problema6()
        {
            //Palindrom
            int x = int.Parse(Console.ReadLine());
            int pal = 0;
            int aux = x;
            while (x != 0)
            {
                pal = pal * 10 + x % 10;
                x = x / 10;
            }
            if (pal == aux)
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NU");
            }
        }

        private static void Problema5()
        {
            //Minimul dintr-o multime introdusa secvential

            int min = int.MaxValue;
            Console.Write("Introduceti un numar: ");
            int x = int.Parse(Console.ReadLine());
            while (x != -1)
            {
                if (x < min)
                {
                    min = x;
                }
                
                
                Console.Write("Introduceti un numar: ");
                x = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Minimul valorilor introduse este {0}", min);
            
            
        }

        private static void Problema4D()
        {
            //Determinarea cifrelor unui numar (descrescator)
            int x = int.Parse(Console.ReadLine());
            int ok = 1;
            int i = 0;
            int[] v = new int[10];

            while (x != 0)
            {
                v[i] = x % 10;
                x = x / 10;
                i++;
                    
            }

            for (int j = 0; j < i - 1; j++)
            {
                if (v[j] > v[j + 1])
                {
                    ok = 0;
                }
            }
            if (ok == 0)
            {
                Console.Write("NU");
            }
            else
            {
                Console.Write("DA");
            }
        }

        private static void Problema4C()
        {
            //Determinarea cifrelor unui numar (crescator)
            int x = int.Parse(Console.ReadLine());
            int ok = 1;
            int i = 0;
            int[] v = new int[10];

            while (x != 0)
            {
                v[i] = x % 10;
                x = x / 10;
                i++;
            }

            for (int j = 0; j < i - 1; j++)
            {

                if (v[j] < v[j + 1])
                {
                    ok = 0;
                }
                
            }
            if (ok == 0)
            {
                Console.Write("NU");
            }
            else
            {
                Console.Write("DA");
            }
        }

        private static void Problema3()
        {
            //Numere Prime
            Console.Write("Introduceti un numar: ");
            int x = int.Parse(Console.ReadLine());
            int nr = 0;

            while (x != -1)
            {
                if (prim(x) == 1)
                {
                    nr++;
                }
                Console.Write("Introduceti un numar: ");
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Numarul de numere prime este {0}", nr);
        }

        private static int prim(int x)
        {
            int ok = 1;
            if (x < 2 || x % 2 == 0 && x != 2)
            {
                ok = 0;
            }

            for (int i = 3; i * i <+ x; i += 2)
            {
                if (x % i == 0)
                {
                    ok = 0;
                }
            }

            return ok;
        }

        private static void Problema2()
        {
            //Elemente identice intr-o multime
            int[] a = new int[] {0, 1, 2, 4, 4, 5, 4, 2, 1, 4};
            int n = a.Length;
            int[] b = new int[n];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                if (!b.Contains(a[i]))
                {
                    int rep = 1;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (a[i] == a[j])
                        {
                            if (!b.Contains(a[i]))
                            {
                                b[index] = a[i];
                                index++;
                            }
                            rep++;
                        }
                    }
                    if (rep > 1)
                    {
                        Console.WriteLine("Valoarea '{0}' se repeta de {1} ori", a[i], rep);
                    }
                }
            }
        }
    }
}

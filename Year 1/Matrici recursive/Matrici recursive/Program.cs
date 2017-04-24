using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrici_recursive
{
    class Program
    {
        public static int n = Convert.ToInt32(Console.ReadLine());
        public static int[,]v = new int[n, n];
        static void Main(string[] args)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    v[i, j] = 0;

			//mat1();//diagonale si margini
			//afisare();
			mat2();//romb;
			afisare();
			mat3();//jumate 1, jumate 0;
			afisare();
			mat4(n - 1);
			afisare();
			mat5(1, 1);
			afisare();
			mat6(n, 0, 0, 1);
			afisare();
			mat7();
			afisare();
			mat8(n - 1);
			afisare();
			mat9(0);
			afisare();
			mat10();
			afisare();
			mat11();
			afisare();
			//mat12();//2 vectori cu elemente cifre, return un vector cu suma numerica (1,2,3,4) + (5,6) = (1,2,9,0)



			Console.ReadKey();
        }

        private static void mat12()
        {
            int[] v1 = new int[] { 1, 2, 3, 4 };
            int[] v2 = new int[] { 5, 6 };
            int[] r = new int[v1.Length > v2.Length ? v1.Length : v2.Length];
            if (v1.Length > v2.Length)
            {
                for (int i = 0; i < v2.Length; i++)
                    r[v1.Length - i - 1] = v1[v1.Length - i - 1] + v2[v2.Length - i - 1];
                for (int i = 0; i < v1.Length - v2.Length; i++)
                {
                    r[v1.Length - v2.Length - i] = r[v1.Length - v2.Length];
                }


            }
                for (int i = 0; i < v2.Length - 1; i++)
                    if (r[v1.Length - i - 1] >= 10)
                    {
                        r[v1.Length - i - 2] += 1;
                        r[v1.Length - i - 1] -= 10;
                    }
            



            for (int i = 0; i < r.Length; i++)
                Console.Write(r[i]);

        }

        private static void mat11()
        {
            int c = 0;
            int d = 1;
            for (int i = 0; i < n; i++)
            {
                if (c % 2 == 0)
                {
                    int j = n - 1;
                    while (j >= 0)
                        v[j--, i] = d++;
                }
                if (c % 2 == 1)
                {

                    int j = 0;
                    while (j <= n - 1)
                        v[j++,i] = d++;
                }
                c++;
            }
        }

        private static void mat10()
        {
            for (int i = 0; i < n; i++)
            {
                v[n / 2, i] = 1;
                v[i, n / 2] = 1;
            }
            for (int i = 1; i < n / 2 - 1; i++)
                for (int j = 1; j < n / 2 - 1; j++)
                {
                    v[i, j] = 1;
                    v[n / 2 + 1 + i, j] = 1;
                }
            for (int i = n / 2 + 2; i < n - 1; i++)
                for (int j = n / 2 + 2; j < n - 1; j++)
                {
                    v[i, j] = 1;
                    v[i - n / 2 - 1, j] = 1;
                }
        }

        private static void mat9(int l)
        {
            if (l <= n / 2)
            {
                mat9(l + 2);
                for (int i = l; i <= n - 1 - l; i++)
                {
                    v[n - l - 1, i] = 1;
                    v[i, n - l - 1] = 1;
                    v[l, i] = 1;
                    v[i, l] = 1;
                }
            }
        }

        private static void mat8(int l)
        {
            if (l >= 0)
            {
                mat8(l - 2);
                for (int i = l; i <= n - 1; i++)
                    {
                        v[i, l] = 1;
                        v[l, i] = 1;
                    }
            }



        }

        private static void mat7()
        {
            for (int i = 0; i <= n / 2 - 1; i++)
                for (int j = i; j <= n - i - 1 ; j++)
                    v[i, j] = 1;


        }

        private static void afisare()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(v[i, j] + " ");
                }
                Console.WriteLine();
            }
			Console.WriteLine();
        }

        private static int mat6(int n, int i, int j, int c)
        {
            if (n == 0)
                return 0;
            else
            {
                if (i == n / 2 + 1)
                {
                    return mat6(n / 2, 0, 0, c + 1);
                }
                else
                {
                    if (j == n / 2 + 1)
                    {
                        return mat6(n, i + 1, 0, c);
                    }
                    else
                    {
                        v[i, j] = c;
                        return mat6(n, i, j + 1, c);
                    }
                }

            }




        }

        private static void mat5(int l, int c)
        {
            if (l <= n)
            {
                mat5(l * 2, c + 1);
                for (int i = 0; i < l; i++)
                    for (int j = 0; j < l; j++)
                        v[i, j] = c;
            }


        }

        private static void mat4(int l)
        {
            if (l >= 0)
            {
                mat4(l - 2);
                for (int i = 0; i < l - 1; i++)
                {
                    v[l - 2, i] = 1;
                    v[i, l - 2] = 1;
                }
            }


        }

        private static void mat3()
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < i + 1; j++)
                    v[i, j] = 1;
        }

        private static void mat2()
        {
            for (int i = 0; i <= (n - 1) / 2; i++)
                for (int k = (n - 1) / 2 - i; k <= (n - 1) / 2 + i; k++)
                {
                    v[i, k] = 1;
                    v[n - 1 - i, k] = 1;
                }
        }

        private static void mat1()
        {
            for (int i = 0; i < n; i++)
            {
                v[i, i] = 1;
                v[i, n - i - 1] = 1;
                v[0, i] = 1;
                v[n - 1, i] = 1;
                v[i, n - 1] = 1;
                v[i, 0] = 1;
                v[(n - 1) / 2, i] = 1;
                v[i, (n - 1) / 2] = 1;
            }


        }
    }
}

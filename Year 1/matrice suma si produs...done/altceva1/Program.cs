using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace altceva1
{
    class Program
    {
        static void Main(string[] args)
        {//suma produsul a 2 matrice
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
                    Console.Write("{0},{1} = ",i, j);
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
            int[,] D = new int[n1, m2];
            if (m1 != n2) Console.WriteLine("Nu se poate face produsul celor doua matrice.");
            else
            {
                Console.WriteLine("Produsul Matricelor:");
                for (int i = 0; i < n1; i++)
                    for (int j = 0; j < m2; j++)
                        for (int k = 0; k < n2; k++)
                            D[i, j] += A[i, k] * B[k, j];


                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < m2; j++)
                        Console.Write("{0} ", D[i, j]);
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}

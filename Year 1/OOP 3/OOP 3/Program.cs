using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region datetime struct
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine("Ora: {0}", dt.Hour);
            Console.WriteLine("Minut: {0}", dt.Minute);
            Console.WriteLine("Second: {0}", dt.Second);

            DateTime dt2 = dt.AddMinutes(100);
            Console.WriteLine(dt2);

            TimeSpan ts = dt2.Subtract(dt);
            Console.WriteLine("100 minute sunt {0} secunde", ts.TotalSeconds);
            #endregion

            DC dc = new DC(9, 3, 2016, 8, 37, 31);

            Console.WriteLine(dc);

            ZileSaptamana z = ZileSaptamana.Miercuri;
            Console.Write(z + ": ");


            switch (z)
            {
                case ZileSaptamana.Luni:
                case ZileSaptamana.Marti:
                case ZileSaptamana.Miercuri:
                case ZileSaptamana.Joi:
                    Console.WriteLine("Bleaaah!");
                    break;
                case ZileSaptamana.Vineri:
                    Console.WriteLine("Iee!");
                    break;
                case ZileSaptamana.Sambata:
                case ZileSaptamana.Duminica:
                    Console.WriteLine("Weekend!");
                    break;
            }
            byte[] array = new byte[1024];
            FileStream fs = new FileStream("input.txt", FileMode.Open);
            try
            {
                fs.Read(array, 0, array.Length);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Ooops!");   
            }
            finally
            {
                fs.Close();
            }




            Console.ReadKey();
        }
    }
}

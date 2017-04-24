using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace CriptareCaezar
{
    class Program
    {
        public static string Filepath = @"..\..\text.txt";
        public static string CryptedPath = @"..\..\crypted.txt";
        public static string DecryptedPath = @"..\..\decrypted.txt";
        public static string aText;
        public static string[] WordsFromFile;
        public static int key;
        //1.un text dintr-un fisier
        //criptare cu +n fara spatiu
        //scrie rezultat in fisier
        //si decriptare cu -n fara spatiu\

        //2.cripteaza folosind sobstitutie monoalfabetica
        //shuffle algorythm
        //criptare - decriptare
        static void Main(string[] args)
        {
            Console.WriteLine("SetKey");
            SetKey();
            Console.WriteLine("FiletoText");
            FiletoText();
            Console.WriteLine("CrypttoFile");
            CrypttoFile();

            Console.ReadKey();
        }

        private static void SetKey()
        {
            Console.WriteLine("Set a key from 0 to 26.");
            key = Convert.ToInt32(Console.ReadLine());
        }

        private static void FiletoText()
        {
            using (StreamReader sr = new StreamReader(Filepath))
            {
                aText = sr.ReadToEnd();
                if (aText != null)
                {
                    aText = aText.ToUpper();
                    WordsFromFile = aText.Split(' ', '\n', '\r');
                    Console.WriteLine(WordsFromFile.Length);
                }
            }
        }

        private static void CrypttoFile()
        {

            //int c;
            //char[] aux;
            //using (StreamWriter sw = new StreamWriter(CryptedPath))
            //{
            //    for (int i = 0; i < WordsFromFile.Length; i++)
            //    {
            //        aux = WordsFromFile[i].ToCharArray();
            //        for (int j = 0; j < aux.Length; j++)
            //        {
            //            c = Convert.ToInt32(aux[j]);
            //            Console.WriteLine("crypt: " + c);
            //            if (aux[j] == ' ' || aux[j] == '\n' || aux[j] == '\r')
            //                sw.Write(aux[j].ToString());
            //            else
            //            {   Console.WriteLine("Before: " + c);
            //                c = Convert.ToInt32(aux[j]) + key;
            //                if (c >= 90)
            //                    c -= 25;
            //                aux[j] = (char)c;
            //                sw.Write(aux[j].ToString());
                            
            //                Console.WriteLine("Key: " + key);
            //                Console.WriteLine("Diference: " + c);
            //                Console.WriteLine();
            //            }
            //            //Console.WriteLine("crypt: " + c);
            //            //Console.WriteLine(aux[j].ToString());
            //        }
            //    }
            //}
            char[] letter;
            char aux;
            using (StreamWriter sw = new StreamWriter(CryptedPath))
            {
                for (int i = 0; i < WordsFromFile.Length; i++)
                {
                    letter = WordsFromFile[i].ToCharArray();
                    for (int j = 0; j < letter.Length; j++)
                    {
                        Console.WriteLine("crypt: " + letter[j]);
                        if (letter[j] == ' ' || letter[j] == '\n' || letter[j] == '\r')
                            sw.Write(letter[j].ToString());
                        else
                        {
                            Console.WriteLine("Before: " + letter[j]);
                            aux = letter[j];
                            if (letter[j] > 'Z')

                                letter[j] -= ;
                            letter[j] = (char)(letter[j] + key);
                            sw.Write(letter[j].ToString());

                            Console.WriteLine("Key: " + key);
                            Console.WriteLine("Diference: " + letter[j]);
                            Console.WriteLine();
                        }
                        //Console.WriteLine("crypt: " + c);
                        //Console.WriteLine(aux[j].ToString());
                    }
                }
            }
        }
    }
}

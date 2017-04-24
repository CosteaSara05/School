using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rd_Lab
{
    class Program
    {
		//1.cifrul lui vigenere cipher
		//criptarea cu cifrul vigenere, fara spatii sau punctuatii
		//se ia dintr-un fisier
		//rezultatul se pune in alt fisier
		//2. cifrul lui play fair
		public static char[] alphabet = new char[26];
		public static char[,] cipher = new char[26, 26];
		static void Main(string[] args)
        {

			populate();
			Console.WriteLine("\nInsert a text: ");
			string text = Console.ReadLine();
			Console.WriteLine("Enter the key: ");
			string key = Console.ReadLine().ToUpper();

			string crypted = Crypt(text, key, -1);
			Console.WriteLine("Crypted: \n" + crypted);

			Console.WriteLine("Enter the key: ");
			key = Console.ReadLine().ToUpper();

			string decrypted = Crypt(text, key, 1);
			Console.WriteLine("Decrypted: \n" + decrypted);
			Console.WriteLine("\nPress any key to continue...");
			Console.ReadKey();
        }


		public static string Crypt(string text, string key, int cd)
		{
			int aux = 0, c;
			string encryptedtext = "";
			text = text.ToUpper();
			key = key.ToUpper();
			foreach (char t in text)
			{
				if (t < 65)
                    continue;
				c = t - 65 + cd * (key[aux] - 65);
				if (c < 0)
                    c += 26;
				encryptedtext += Convert.ToChar(65 + (c % 26));
				if (++aux == key.Length)
                    aux = 0;
			}

			return encryptedtext;
		}

		public static void populate()
		{
			int c = 65, c2;
			//Console.Write("   ");
			for (int i = 0; i < alphabet.Length; i++)
			{
				alphabet[i] = (char)c++;
				//Console.Write(alphabet[i] + " ");
			}
			//Console.WriteLine("\n");
			c = 65;
			char index = 'A';
			for (int i = 0; i < 26; i++)
			{
				c2 = c + i;
				Console.Write(index++ + "  ");
				for (int j = 0; j < 26; j++)
				{
					if (c2 == 91)
						c2 = 65;
					cipher[i, j] = (char)c2++;
					//Console.Write(cipher[i,j] + " ");
					
				}
				c = 65;
				//Console.WriteLine();
			}
		}
	}
}

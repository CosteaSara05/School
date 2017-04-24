using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_number_made_by_random_numbers
{
	class Program
	{
		//Largest number made by random numbers
		//95,951
		//no: 95195
		//yes:95951
		static void Main(string[] args)
		{
			List<int> numbersList = InsertNumbers();
			int[] numbers = new int[numbersList.Count];
			for (int i = 0; i < numbersList.Count - 2; i++)
			{
				char[] numberCharacters = numbersList[i].ToString().ToCharArray();
				char[] toCompareWith = numbersList[i + 1].ToString().ToCharArray();
				bool first = false, second = false;
				for (int j = 0; j < numberCharacters.Length; j++)
				{
					if (numberCharacters[j] != null && toCompareWith[j] != null)
					{
						if (numberCharacters[j] < toCompareWith[j])
						{
							second = true;
							first = false;
							//numbers[i] = numbersList[i];
						}
						else if (numberCharacters[j] == toCompareWith[j])
						{

						}
						else
						{
							first = true;
							second = false;
						}
					}
				}
			}


			Console.ReadKey();
		}

		public static List<int> InsertNumbers()
		{
			List<int> numbers = new List<int>();
			int extractInt = 0;
			do
			{
				extractInt = Convert.ToInt32(Console.ReadLine());
				numbers.Add(extractInt);
			} while (extractInt != 0);
			Console.WriteLine("List done.");
			return numbers;
		}
	}
}

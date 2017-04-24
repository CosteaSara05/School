using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
	class Program
	{
		public static List<Account> Accounts = new List<Account>();
		public static List<Customer> Customers = new List<Customer>();
		public static ulong Numar_cont = 0;
		static void Main(string[] args)
		{


			The_Bank();
			
			



			Console.ReadKey();
		}


		#region Bank

		public static void The_Bank()
		{
			Console.WriteLine("Bun venit la Banca.\nOperatiuni:");
			Bank_Operations();
		}

		public static void Bank_Operations()
		{
			Account account = new Account(null, 0, 0);
			int Operation, alege, c = 0;
			do
			{
				if (c != 0)
					Console.Clear();
				Bank_Operation_View();
				Operation = Convert.ToInt32(Console.ReadLine());
				switch (Operation)
				{
					case 1:
						Console.WriteLine("1.Creare cont nou.");
						account = New_Account();
						break;
					case 2:
						Console.WriteLine("2.Selecteaza cont pentru efectuarea de operatiuni.");
						Account_Operations(account = Select_Account);
						break;
					case 3:
						Console.WriteLine("La revedere.");
						break;
				}
				Console.WriteLine("1.Doriti sa selectati alt cont sau sa creati unul nou.\n2.Executati o operatiune.\n3.Terminare si iesire.");
				alege = Convert.ToInt32(Console.ReadLine());
				if (alege == 3)
					Console.WriteLine("La revedere.");
				if (alege == 2)
				{
					Account_Operations(account);
					alege = 1;
				}
				c++;
			} while (alege == 1);
		}

		public static void Bank_Operation_View()
		{
			Console.WriteLine("1.Creare cont nou.");
			Console.WriteLine("2.Selecteaza cont.");
			Console.WriteLine("3.Iesire din banca.");
		}

		#endregion

		#region Select Account
		public static Account Select_Account
		{
			get
			{
				int Operation = Accounts_Actions_View();
				Account account;
				do
				{
					if (Operation == 1)
					{
						Console.WriteLine("1.Cauta cont dupa proprietar.");
						account = Choose_Account_By_Customer();
						return account;
					}
					else if (Operation == 2)
					{
						Console.WriteLine("2.Cauta cont dupa numar.");
						account = Choose_Account_By_Number();
						return account;
					}
					Console.WriteLine("1.Pentru o noua cautare.\n2.Pentru a intra in operatiunile contului.");
					int repeat = Convert.ToInt32(Console.ReadLine());
					Console.Clear();
					if (repeat == 1)
						Operation = Accounts_Actions_View();
				} while (Operation == 1 || Operation == 2);
				return null;
			}
		}

		public static int Accounts_Actions_View()
		{
			Console.Clear();
			Console.WriteLine("1.Cauta cont dupa proprietar.");
			Console.WriteLine("2.Cauta cont dupa numar.");
			int Operation = Convert.ToInt32(Console.ReadLine());
			Console.Clear();
			return Operation;
		}

		public static Account Choose_Account_By_Customer()
		{
			Account account = new Account(null, 0, 0);
			int alegere = 2, c = 0;
			do
			{
				if (c != 0)
					Console.Clear();
				Customer customer = new Customer(null, null, 0);
				Console.Write("Nume: ");
				customer.Nume = Console.ReadLine();
				Console.Write("Prenume: ");
				customer.Prenume = Console.ReadLine();
				foreach (Account acc in Accounts)
					if ((customer.Nume == acc.Owner.Nume) && (customer.Prenume == acc.Owner.Prenume))
						account = acc;
					if ((customer.Nume == account.Owner.Nume) && (customer.Prenume == account.Owner.Prenume))
					{
						Console.Clear();
						Console.Write("{0} are cont.\n1. Selectare {0}\n2.Cauta din nou.\n", account.Owner.Nume + " " + account.Owner.Prenume);
						alegere = Convert.ToInt32(Console.ReadLine());
						if (alegere == 1)
							return account;
					}
					else
					{
						Console.Clear();
						Console.Write("Proprietarul nu a fost gasit.\n1.Iesire\n2.Cauta din nou.\n");
						alegere = Convert.ToInt32(Console.ReadLine());
					}
				
			} while (alegere == 2);
			return null;
		}

		public static Account Choose_Account_By_Number()
		{
			Account account = new Account(null, 0, 0);
			int alegere = 2, c = 0;
			do
			{
				if (c != 0)
					Console.Clear();
				Console.Write("Numarul contului: ");
				ulong Account_Number = Convert.ToUInt64(Console.ReadLine());
				foreach (Account acc in Accounts)
					if (Account_Number == acc.Number)
						account = acc;
				if (Account_Number == account.Number)
				{
					Console.Clear();
					Console.Write("{0}.\n1. Selectare {0}\n2.Cauta din nou.\n", account.Owner.Nume + " " + account.Owner.Prenume);
					alegere = Convert.ToInt32(Console.ReadLine());
					if (alegere == 1)
						return account;
				}
				else
				{
					Console.Clear();
					Console.Write("Proprietarul nu a fost gasit.\n1.Iesire\n2.Cauta din nou.\n");
					alegere = Convert.ToInt32(Console.ReadLine());
				}
			} while (alegere == 2);
			return null;
		}

		#endregion

		#region Account Actions

		public static void Depunere(Account curent)
		{
			Console.Clear();
			ViewSold(curent);
			Console.Write("Introduce-ti suma de bani pentru depunere: ");
			int cash = Program.ExtractInt();
			if (cash > 10)
			{
				curent.Sold += cash;
				Console.WriteLine("Suma {0} a fost depusa cu succes.\nSold curent: {1}", cash, curent.Sold);
			}
			else if ((cash <= 10) && (cash > 0))
			{
				Console.WriteLine("Nu poti extrage ultimi bani.");
			}
			else
				Console.WriteLine("A aparut o eroare. Nu s-a intamplat nimic. Va rugam repetati actiunea.");
		}

		public static void Ridicare(Account curent)
		{
			Console.Clear();
			ViewSold(curent);
			Console.Write("Introduce-ti suma de bani pentru ridicare: ");
			int money = Program.ExtractInt();
			if ((curent.Sold >= money) && (curent.Sold > 10))
			{
				curent.Sold -= money;
				Console.WriteLine("Suma {0} a fost extrasa cu succes.\nSold curent: {1}", money, curent.Sold);
			}
			else
				Console.WriteLine("Sold insuficient.");
		}

		public static void ViewSold(Account curent)
		{
			Console.Clear();
			Console.WriteLine("Sold: {0}", curent.Sold);
			Console.WriteLine();
		}

		public static void ViewDetails(Account curent)
		{
			Console.Clear();
			Console.WriteLine("Proprietar: {0}\nSold: {1}\nNumarul contului: {2}", curent.Owner.Prenume + " " + curent.Owner.Nume, curent.Sold, curent.Number);
			Console.WriteLine();
		}

		public static void Account_Operations(Account curent)
		{
			Console.Clear();
			Console.WriteLine("Bun venit Domnule {0},", curent.Owner.Nume + " " + curent.Owner.Prenume);
			int Operation = Account_Operations_View();
			do
			{
				switch (Operation)
				{
					case 1:
						Console.WriteLine("1.Operatiunea depunere.");
						Depunere(curent);
						break;
					case 2:
						Console.WriteLine("2.Operatiunea ridicare.");
						Ridicare(curent);
						break;
					case 3:
						Console.WriteLine("3.Verificare sold.");
						ViewSold(curent);
						break;
					case 4:
						Console.WriteLine("4.Detalii cont.");
						ViewDetails(curent);
						break;
				}
				Console.WriteLine();
				Operation = 0;
				Console.WriteLine("1.Pentru o noua operatiune.\n2.Pentru iesire cont.");
				Operation = Convert.ToInt32(Console.ReadLine());
				Console.Clear();
				if (Operation == 1)
					Operation = Account_Operations_View();
				if (Operation == 2)
					Operation = 5;
			} while ((Operation >= 1) && (Operation <= 4));
		}

		public static int Account_Operations_View()
		{
			Console.Clear();
			Console.WriteLine("Ce doriti sa faceti?");
			Console.WriteLine("1.Operatiunea depunere.");
			Console.WriteLine("2.Operatiunea ridicare.");
			Console.WriteLine("3.Verificare sold.");
			Console.WriteLine("4.Detalii cont.");
			int Operation = Convert.ToInt32(Console.ReadLine());
			return Operation;
		}
		#endregion

		#region Create New Account and Customer
		public static Account New_Account()
		{
			Console.Clear();
			Console.WriteLine("Creare cont nou.");
			Account curent;
			Accounts.Add(curent = new Account(NewAccount_Owner(), NewAccount_Sold(), NewAccount_Number()));
            New_Account_file(curent);
            ViewDetails(curent);
			return curent;
		}

        public static void New_Account_file(Account curent)
        {
            string path = @".\customers.txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Customers and bank accounts:");
                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(curent.Owner.Nume.ToString() + "|" + curent.Owner.Prenume.ToString() + "|" + curent.Owner.Varsta.ToString() + "|" + curent.Number.ToString() + "|" + curent.Sold.ToString());
            }
        }

        public static Customer NewAccount_Owner()
		{
			Customer owner;
			Console.WriteLine("Creare client nou.");
			Customers.Add(owner = new Customer(NewCustomer_Name(), NewCustomer_Prename(), NewCustomer_Age()));
			return owner;
		}

		public static int NewAccount_Sold()
		{
			Console.Write("Cu ce suma de bani doriti sa deschideti contul: ");
			int n = ExtractInt();
			return n;
		}

		public static ulong NewAccount_Number()
		{
			return ++Numar_cont;
		}

		public static string NewCustomer_Name()
		{
			Console.Write("Nume: ");
			string Nume = Console.ReadLine();
			return Nume;
		}

		public static string NewCustomer_Prename()
		{
			Console.Write("Prenume: ");
			string Prenume = Console.ReadLine();
			return Prenume;
		}

		public static int NewCustomer_Age()
		{
			Console.Write("Varsta: ");
			int varsta = Convert.ToInt32(Console.ReadLine());
			return varsta;
		}

		#endregion//done

		#region Helper Methods
		public static int ExtractInt()
		{
			int n = Convert.ToInt32(Console.ReadLine());
			return n;
		}
		#endregion
	}
}

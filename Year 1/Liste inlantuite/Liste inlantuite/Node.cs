using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste_inlantuite
{
	class Node
	{
		public object Data;
		public Node Next;

		public Node(object data)
		{
			Data = data;
		}
	}


	class LinkedLista
	{
		Node adresa;
		Node informatie;

		public void Add(Node newNode)
		{
			if (adresa == null)
			{
				adresa = newNode;
				informatie = adresa;
			}
			else
			{
				informatie.Next = newNode;
				informatie = informatie.Next;
			}
		}

		public void View()
		{
			while (adresa != null)
			{
				Console.WriteLine(adresa.Data);
				adresa = adresa.Next;
			}
		}
	}
}

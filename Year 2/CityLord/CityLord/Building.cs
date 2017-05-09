using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CityLord
{
	public class Building
	{
		public static int DrawSize;
		public Button IMG;
		public int price;
		public bool IsBought;
		public bool IsClicked;
		public int IndexImg;
		public Player Owner;
		public int Number;
		public Building(Button IMG, int price, bool IsBought, bool IsClicked, int IndexImg, Player Owner, int Number)
		{
			this.IMG = IMG;
			this.price = price;
			this.IsBought = IsBought;
			this.IsClicked = IsClicked;
			this.IndexImg = IndexImg;
			this.Owner = Owner;
			this.Number = Number;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityLord
{
	public class Building
	{
		public static int DrawSize;
		public PictureBox PB = new PictureBox();
		public int price;
		public bool IsBought;
		public bool IsClicked;
		public int IndexImg;
		public Player Owner;
		public int Number;
		public Building(PictureBox pb, int price, bool IsBought, bool IsClicked, int IndexImg, Player Owner, int Number)
		{
			PB = pb;
			this.price = price;
			this.IsBought = IsBought;
			this.IsClicked = IsClicked;
			this.IndexImg = IndexImg;
			this.Owner = Owner;
			this.Number = Number;
		}
	}
}

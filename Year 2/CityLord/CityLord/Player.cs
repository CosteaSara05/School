using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CityLord
{
	public class Player
	{
		public Color PlayerColor;
		public string Name;
		public int Money;
		public List<Building> PlayerProps;
		public Player(string Name, Color PlayerColor, int Money, List<Building> PlayerProps)
		{
			this.Name = Name;
			this.PlayerColor = PlayerColor;
			this.Money = Money;
			this.PlayerProps = PlayerProps;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CityLord
{
	public class ColorChooser
	{
		public Color color;
		public bool isSelected;
		public ColorChooser(Color color, bool isSelected)
		{
			this.color = color;
			this.isSelected = isSelected;
		}
	}
}

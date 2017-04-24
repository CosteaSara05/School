using System.Collections.Generic;
using System.Drawing;

namespace LandLord
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
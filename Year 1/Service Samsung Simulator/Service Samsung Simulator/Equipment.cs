using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Samsung_Simulator
{
	public class Equipment
	{
		public float cost;
		public string neededatoperation;

		public Equipment(float cost, string neededatoperation)
		{
			this.cost = cost;
			this.neededatoperation = neededatoperation;
		}
	}
}

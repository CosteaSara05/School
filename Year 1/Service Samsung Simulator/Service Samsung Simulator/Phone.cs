using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Samsung_Simulator
{
	public class Phone
	{
		public string curentoperation;
		public float costs;
		public float income;
		public DateTime datein;
		public float penalty;

		public Phone(string curentoperation, float costs, float income, DateTime datein, float penalty)
		{
			this.curentoperation = curentoperation;
			this.costs = costs;
			this.income = income;
			this.datein = datein;
			this.penalty = penalty;
		}
	}
}

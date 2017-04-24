using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Samsung_Simulator
{
	public class Worker
	{
		public string operation;
		public float salarynow;
		public float salarylast;
		public int workedhours;
		public int overtime;
		public bool Saturday;
		public bool shift;//true - morning, false - afternoon

		public Worker(string operation, float salarynow, float salarylast, int workedhours, int overtime, bool Saturday, bool shift)
		{
			this.operation = operation;
			this.salarynow = salarynow;
			this.salarylast = salarylast;
			this.workedhours = workedhours;
			this.overtime = overtime;
			this.Saturday = Saturday;
			this.shift = shift;
		}
	}
}

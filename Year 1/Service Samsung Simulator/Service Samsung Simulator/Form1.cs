using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_Samsung_Simulator
{
	public partial class Form1 : Form
	{
		public Random r = new Random();
		public static List<Label> Operators = new List<Label>();
		public static List<Label> Waiting = new List<Label>();
		public static List<Label> Done = new List<Label>();
		public static List<Worker> Workers = new List<Worker>();
		public static List<int> PhonesPerHour = new List<int>();
		public int flowing;
		public int inboundphones = 500;
		public static bool IsSaturday;

		public Form1()
		{
			InitializeComponent();
		}

		#region Buttons
		private void NGbutton_Click(object sender, EventArgs e)
		{
			MainMenupanel.Visible = false;
			MainGamepanel.Visible = true;
			SwitcherOpTab.Visible = true;
			QGbutton.Visible = true;
			FirstDay();
		}

		private void Exitbutton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void QGbutton_Click(object sender, EventArgs e)
		{
			QuitGameAvt.Visible = true;
			Flowtime.Enabled = false;
		}

		private void minushibtn_Click(object sender, EventArgs e)
		{
			int i = Convert.ToInt32(Avhrlbl.Text);
			int j = Convert.ToInt32(Hiringlbl.Text);

			if (j > 0)
			{
				minushibtn.Visible = true;
				plushibtn.Visible = true;
				Hirebtn.Enabled = true;
			}
			if (minushibtn.Visible == true)
			{
				j--;
				Hiringlbl.Text = j.ToString();
				if (j == 0)
				{
					minushibtn.Visible = false;
					plushibtn.Visible = true;
					Hirebtn.Enabled = false;
				}
			}
		}

		private void plushibtn_Click(object sender, EventArgs e)
		{
			int i = Convert.ToInt32(Avhrlbl.Text);
			int j = Convert.ToInt32(Hiringlbl.Text);

			if (i == j)
			{
				plushibtn.Visible = false;
				minushibtn.Visible = true;
			}
			if (i > j)
			{
				plushibtn.Visible = true;
				minushibtn.Visible = true;
			}
			if (plushibtn.Visible == true)
			{
				j++;
				Hiringlbl.Text = j.ToString();
				if (j > 0)
				{
					Hirebtn.Enabled = true;
					if (i == j)
					{
						plushibtn.Visible = false;
						minushibtn.Visible = true;
					}
				}
			}
		}

		private void Hirebtn_Click(object sender, EventArgs e)
		{
			int i = Convert.ToInt32(Avoplbl.Text);
			i += Convert.ToInt32(Hiringlbl.Text);
			Avoplbl.Text = i.ToString();
			int j = Convert.ToInt32(Avhrlbl.Text);
			j -= Convert.ToInt32(Hiringlbl.Text);
			Avhrlbl.Text = j.ToString();
			Hiringlbl.Text = "0";
			UpdateButtons();
		}

		private void minusasbtn_Click(object sender, EventArgs e)
		{
			int i = Convert.ToInt32(Avoplbl.Text);
			int j = Convert.ToInt32(Asignlbl.Text);

			if (j > 0)
			{
				minushibtn.Visible = true;
				plushibtn.Visible = true;
				Asignbtn.Enabled = true;
			}
			if (minusasbtn.Visible == true)
			{
				j--;
				Asignlbl.Text = j.ToString();
				if (j == 0)
				{
					minusasbtn.Visible = false;
					plusasbtn.Visible = true;
					Asignbtn.Enabled = false;
				}
			}
		}

		private void plusasbtn_Click(object sender, EventArgs e)
		{
			int i = Convert.ToInt32(Avoplbl.Text);
			int j = Convert.ToInt32(Asignlbl.Text);

			if (i == j)
			{
				plusasbtn.Visible = false;
				minusasbtn.Visible = true;
			}
			if (i > j)
			{
				plusasbtn.Visible = true;
				minusasbtn.Visible = true;
			}
			if (plusasbtn.Visible == true)
			{
				j++;
				Asignlbl.Text = j.ToString();
				if (j > 0)
				{
					Asignbtn.Enabled = true;
					if (i == j)
					{
						plusasbtn.Visible = false;
						minusasbtn.Visible = true;
					}
				}
			}
		}

		private void Asignbtn_Click(object sender, EventArgs e)
		{
			int k = Convert.ToInt32(Asignlbl.Text);
			for (int i = 0; i < Operators.Count; i++)
				if (i == Asignbox.SelectedIndex)
				{
					string op = Operators[i].Text;
					int number = Convert.ToInt32(op);
					Operators[i].Text = (number + k).ToString();
					number = Convert.ToInt32(Asignlbl.Text);
					op = Asignbox.Text;
					AddWorkers(op, number);
				}
			int j = Convert.ToInt32(Avoplbl.Text);
			j -= Convert.ToInt32(Asignlbl.Text);
			Avoplbl.Text = j.ToString();
			Asignlbl.Text = "0";
			UpdateButtons();
		}

		private void QuitSurebtn_Click(object sender, EventArgs e)
		{
			MainMenupanel.Visible = true;
			MainGamepanel.Visible = false;
			SwitcherOpTab.Visible = false;
			QGbutton.Visible = false;
			QuitGameAvt.Visible = false;
		}

		private void QuitCancelbtn_Click(object sender, EventArgs e)
		{
			QuitGameAvt.Visible = false;
			Flowtime.Enabled = true;
		}

		private void NextDaybtn_Click(object sender, EventArgs e)
		{
			NextDayAvtText.Visible = false;
			NextDaybtn.Visible = false;
			Flowtime.Enabled = true;
		}

		private void YesSaturdaybtn_Click(object sender, EventArgs e)
		{
			SaturdayAvtText.Visible = false;
			YesSaturdaybtn.Visible = false;
			NoSaturdaybtn.Visible = false;
			NextDayAvtText.Visible = false;
			NextDaybtn.Visible = false;
			Saturday();
			Flowtime.Enabled = true;
		}

		private void NoSaturdaybtn_Click(object sender, EventArgs e)
		{
			SaturdayAvtText.Visible = false;
			YesSaturdaybtn.Visible = false;
			NoSaturdaybtn.Visible = false;
			NextDay();
			NextDayAvtText.Visible = false;
			NextDaybtn.Visible = false;
			MonthDaylbl.Text = (Convert.ToInt32(MonthDaylbl.Text) + 1).ToString();
			Daylbl.Text = (Convert.ToInt32(Daylbl.Text) + 1).ToString();
			WeekDaylbl.Text = "1";
			Flowtime.Enabled = true;
		}


		#endregion

		private void AddWorkers(string Operation, int WorkersToAdd)
		{
			int c = 0;
			for (int i = 0; i < WorkersToAdd; i++)
			{
				c = r.Next(2);
				if (c == 1)
					Workers.Add(new Worker(Operation, 0, 0, 0, 0, false, true));
				else
					Workers.Add(new Worker(Operation, 0, 0, 0, 0, false, false));
			}
		}

		public void FirstDay()
		{
			for (int i = 0; i < Operators.Count; i++)
			{
				Operators[i].Text = "0";
				Waiting[i].Text = "0";
				Done[i].Text = "0";
			}
			Inwalbl.Text = inboundphones.ToString();
			Workers.Clear();
			PBcolbl.Text = "0";
			OCcolbl.Text = "0";
			PQcolbl.Text = "0";
			moneylbl.Text = "0";
			MonthDaylbl.Text = "1";
			WeekDaylbl.Text = "1";
			Daylbl.Text = "1";
			Hourslbl.Text = "06";
			minuteslbl.Text = "30";
			NextDayAvtText.Visible = false;
			NextDaybtn.Visible = false;
			IsSaturday = false;


			Avhrlbl.Text = r.Next(0, 4).ToString();
			minushibtn.Visible = false;
			plushibtn.Visible = true;
			Hiringlbl.Text = "0";
			Hirebtn.Enabled = false;

			Avoplbl.Text = "0";
			minusasbtn.Visible = false;
			plusasbtn.Visible = true;
			Asignlbl.Text = "0";
			Asignbtn.Enabled = false;

			if (Avhrlbl.Text == "0")
			{
				plushibtn.Visible = false;
				minushibtn.Visible = false;
				Hirebtn.Enabled = false;
			}
			if (Avoplbl.Text == "0")
			{
				plusasbtn.Visible = false;
				minusasbtn.Visible = false;
				Asignbtn.Enabled = false;
			}
			flowing = 30;
			Flowtime.Enabled = true;
		}

		private void NextDay()
		{
			Avhrlbl.Text = r.Next(0, 4).ToString();
			UpdateButtons();
			NextDayAvtText.Visible = true;
			NextDaybtn.Visible = true;
			Daylbl.Text = (Convert.ToInt32(Daylbl.Text) + 1).ToString();
			WeekDaylbl.Text = (Convert.ToInt32(WeekDaylbl.Text) + 1).ToString();
			MonthDaylbl.Text = (Convert.ToInt32(MonthDaylbl.Text) + 1).ToString();
			if (Convert.ToInt32(WeekDaylbl.Text) % 6 == 0)
			{
				NextDayAvtText.Visible = false;
				NextDaybtn.Visible = false;
				SaturdayAvtText.Visible = true;
				YesSaturdaybtn.Visible = true;
				NoSaturdaybtn.Visible = true;
				IsSaturday = true;
			}
			for (int i = 0; i < Operators.Count; i++)
				Done[i].Text = "0";
			//Inwalbl.Text = inboundphones.ToString();
			NextMonth();
		}

		private void NextMonth()
		{
			if (Convert.ToInt32(Daylbl.Text) >= 30)
			{
				foreach (Worker item in Workers)
				{
					//pay the people
					item.overtime = 0;
					item.salarylast = item.salarynow;
					item.salarynow = 0;
					item.workedhours = 0;
				}
			}
		}

		private void Shifts()
		{
			foreach (Worker item in Workers)
			{
				if (IsSaturday == false)
				{
					if (item.shift == true && Convert.ToInt32(Hourslbl.Text) == 6)
					{
						item.workedhours += 8;
						Overtime(item);
					}
					else if (item.shift == false && Convert.ToInt32(Hourslbl.Text) == 15)
						item.workedhours += 8;
				}
				if (IsSaturday == true && item.Saturday == true)
					item.overtime += 8;
			}
		}

		public void Overtime(Worker item)
		{
			int i = r.Next(0, 101);
			if (i % r.Next(2, 15) == 0)
				item.overtime += 2;
		}

		private void Saturday()
		{
			foreach (Worker item in Workers)
			{
				int i = r.Next(0, 101);
				if (i % r.Next(2, 15) == 0)
					item.Saturday = true;
			}
		}

		private void UpdateButtons()
		{
			UpdateHireButtons();
			UpdateAsignButtons();
		}

		private void UpdateHireButtons()
		{
			int i = Convert.ToInt32(Avhrlbl.Text);
			int j = Convert.ToInt32(Hiringlbl.Text);

			if (j > 0)
			{
				Hirebtn.Enabled = true;
				if (i == j)
				{
					plushibtn.Visible = false;
					minushibtn.Visible = true;
				}
				else if (i > j)
					plushibtn.Visible = true;
			}
			else if (i == 0)
			{
				minushibtn.Visible = false;
				plushibtn.Visible = false;
				Hirebtn.Enabled = false;
			}
			else if (j == 0)
			{
				minushibtn.Visible = false;
				plushibtn.Visible = true;
				Hirebtn.Enabled = false;
			}
		}

		private void UpdateAsignButtons()
		{
			int i = Convert.ToInt32(Avoplbl.Text);
			int j = Convert.ToInt32(Asignlbl.Text);

			if (j > 0)
			{
				Asignbtn.Enabled = true;
				if (i == j)
				{
					plusasbtn.Visible = false;
					minusasbtn.Visible = true;
				}
				else if (i > j)
					plusasbtn.Visible = true;
			}
			else if (i == 0)
			{
				minusasbtn.Visible = false;
				plusasbtn.Visible = false;
				Asignbtn.Enabled = false;
			}
			else if (j == 0)
			{
				minusasbtn.Visible = false;
				plusasbtn.Visible = true;
				Asignbtn.Enabled = false;
			}
		}

		public void Populate_AsignBoxAndOperations()
		{
			Asignbox.Items.Add("Inbound");
			Asignbox.Items.Add("Block cell");
			Asignbox.Items.Add("PBA repair");
			Asignbox.Items.Add("OCTA");
			Asignbox.Items.Add("Collecting");
			Asignbox.Items.Add("Download");
			Asignbox.Items.Add("RF");
			Asignbox.Items.Add("Calibration");
			Asignbox.Items.Add("IMEI");
			Asignbox.Items.Add("PQC");
			Asignbox.Items.Add("Visual");
			Asignbox.Items.Add("Laser");
			Asignbox.Items.Add("Packing");

			Operators.Add(Inoplbl);
			Operators.Add(Bloplbl);
			Operators.Add(PBoplbl);
			Operators.Add(OCoplbl);
			Operators.Add(Cooplbl);
			Operators.Add(Dooplbl);
			Operators.Add(RFoplbl);
			Operators.Add(Caoplbl);
			Operators.Add(IMoplbl);
			Operators.Add(PQoplbl);
			Operators.Add(Vioplbl);
			Operators.Add(Laoplbl);
			Operators.Add(Paoplbl);

			Waiting.Add(Inwalbl);
			Waiting.Add(Blwalbl);
			Waiting.Add(PBwalbl);
			Waiting.Add(OCwalbl);
			Waiting.Add(Cowalbl);
			Waiting.Add(Dowalbl);
			Waiting.Add(RFwalbl);
			Waiting.Add(Cawalbl);
			Waiting.Add(IMwalbl);
			Waiting.Add(PQwalbl);
			Waiting.Add(Viwalbl);
			Waiting.Add(Lawalbl);
			Waiting.Add(Pawalbl);

			Done.Add(Indolbl);
			Done.Add(Bldolbl);
			Done.Add(PBdolbl);
			Done.Add(OCdolbl);
			Done.Add(Codolbl);
			Done.Add(Dodolbl);
			Done.Add(RFdolbl);
			Done.Add(Cadolbl);
			Done.Add(IMdolbl);
			Done.Add(PQdolbl);
			Done.Add(Vidolbl);
			Done.Add(Ladolbl);
			Done.Add(Padolbl);

			PhonesPerHour.Add(r.Next(75, 80));//inbound
			PhonesPerHour.Add(r.Next(20, 40));//blockcell
			PhonesPerHour.Add(r.Next(5, 7));//pba
			PhonesPerHour.Add(r.Next(30, 70));//octa
			PhonesPerHour.Add(r.Next(150, 180));//collecting
			PhonesPerHour.Add(r.Next(50, 100));//download
			PhonesPerHour.Add(r.Next(5, 20));//rf
			PhonesPerHour.Add(r.Next(15, 25));//calibrare
			PhonesPerHour.Add(r.Next(15, 30));//imei
			PhonesPerHour.Add(r.Next(5, 8));//pqc
			PhonesPerHour.Add(r.Next(25, 45));//visual
			PhonesPerHour.Add(r.Next(40, 55));//laser
			PhonesPerHour.Add(r.Next(20, 27));//packing

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Populate_AsignBoxAndOperations();
			Asignbox.SelectedIndex = 0;

		}

		private void Flowtime_Tick(object sender, EventArgs e)
		{
			flowing++;
			if (flowing == 59)
			{
				if (Convert.ToInt32(Hourslbl.Text) >= 7)
					PhonesRepair();
				if (Convert.ToInt32(Hourslbl.Text) == 6 || Convert.ToInt32(Hourslbl.Text) == 15)
					Shifts();
				flowing = 0;
				Hourslbl.Text = (Convert.ToInt32(Hourslbl.Text) + 1).ToString();
				if (Convert.ToInt32(Hourslbl.Text) == 23 || (Convert.ToInt32(Hourslbl.Text) == 15 && IsSaturday == true))
				{
					Flowtime.Enabled = false;
					Hourslbl.Text = "6";
					flowing = 30;
					NextDay();
					if (Convert.ToInt32(WeekDaylbl.Text) % 7 == 0)
					{
						MonthDaylbl.Text = (Convert.ToInt32(MonthDaylbl.Text) + 1).ToString();
						WeekDaylbl.Text = "1";
						Daylbl.Text = (Convert.ToInt32(Daylbl.Text) + 1).ToString();
					}
					if (Convert.ToInt32(MonthDaylbl.Text) % 30 == 0 || Convert.ToInt32(MonthDaylbl.Text) >= 30)
					{
						MonthDaylbl.Text = "1";
					}
				}
			}
			minuteslbl.Text = flowing.ToString();
		}

		private void PhonesRepair()
		{
			int operators = 0;
			uint done = 0;
			uint waiting = 0;
			uint waiting2 = 0;
			uint phonesperhour = 0;
			for (int i = 1; i <= Operators.Count; i++)
			{
				foreach (Worker item in Workers)
					if (item.operation == Operators[i - 1].Text)//match them!
					{
						if (item.shift == true && Convert.ToInt32(Hourslbl.Text) < 15)
							operators++;
						else if (item.shift == false && Convert.ToInt32(Hourslbl.Text) >= 15 && IsSaturday == false)
							operators++;
					}
			

				//operators = Convert.ToInt32(Operators[i - 1].Text);
				done = Convert.ToUInt32(Done[i - 1].Text);
				waiting = Convert.ToUInt32(Waiting[i - 1].Text);
				if (i < Operators.Count)
					waiting2 = Convert.ToUInt32(Waiting[i].Text);
				if (waiting > 0 && operators > 0)
				{
					phonesperhour = Convert.ToUInt32(PhonesPerHour[i - 1] * operators);
					if (phonesperhour >= waiting)
					{
						done += waiting;
						waiting = 0;
						waiting2 += phonesperhour;
					}
					else
					{
						done += phonesperhour;
						waiting -= phonesperhour;
						waiting2 += phonesperhour;
					}
					Done[i - 1].Text = done.ToString();
					Waiting[i - 1].Text = waiting.ToString();
					if (i < Operators.Count)
						Waiting[i].Text = waiting2.ToString();
					//unknown issue to change # of phones from one step to another


				}
			}
		}

		
	}
}

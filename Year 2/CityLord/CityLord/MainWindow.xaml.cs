using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CityLord
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		public int Money;
		public Player owner;
		private List<Building> OwnerProps = new List<Building>();
		public static Random r = new Random();
		public static int Price;
		public static int BorGsL = 26;
		public List<Building> BuildingList = new List<Building>();
		public List<PictureBox> PictureBoxList = new List<PictureBox>();
		public int BorGsItem;
		public int BorGsIndex;
		public PictureBox[,] BorGs = new PictureBox[BorGsL, BorGsL];
		public int flowing;
		public int TotalMapItems;
		public int TotalBuildings;
		public int Rent;
		public int Imposit;

		public void MapGenerator()
		{
			int resx = 400;
			int resy = 40;
			TotalMapItems = 0;
			for (int i = 0; i < BorGsL - 9; i++)
			{
				for (int j = 0; j < BorGsL; j++)
				{
					TotalMapItems++;
					resx += Building.DrawSize;
					BorGs[i, j] = new PictureBox();
					BorGs[i, j].Location = new Point(resx, resy);
					BorGs[i, j].Name = "pb" + i.ToString();
					BorGs[i, j].Size = new Size(Building.DrawSize, Building.DrawSize);
					BorGsItem = r.Next(0, 10);
					if (BorGsItem >= 2)
					{
						BorGsIndex = r.Next(1, 4);
						if (BorGsIndex == 1)
						{
							BorGs[i, j].BackgroundImage = LandLord.Properties.Resources._1x1_White;
							BorGs[i, j].BackgroundImageLayout = ImageLayout.Stretch;
						}
						if (BorGsIndex == 2)
						{
							BorGs[i, j].BackgroundImage = LandLord.Properties.Resources._1x2_White;
							BorGs[i, j].BackgroundImageLayout = ImageLayout.Stretch;
						}
						if (BorGsIndex == 3)
						{
							BorGs[i, j].BackgroundImage = LandLord.Properties.Resources._2x1_White;
							BorGs[i, j].BackgroundImageLayout = ImageLayout.Stretch;
						}
					}
					else
						BorGs[i, j].BackColor = Color.Green;
					BorGs[i, j].Visible = true;
					BorGs[i, j].BorderStyle = BorderStyle.FixedSingle;
					if (BorGsItem >= 2)
					{
						BorGs[i, j].Click += new EventHandler(Building_Click);
					}
					else
						BorGs[i, j].Click += new EventHandler(Grass_Click);
					this.Controls.Add(BorGs[i, j]);
					PictureBoxList.Add(BorGs[i, j]);
					progressBar1.PerformStep();
				}
				resx = 400;
				resy += Building.DrawSize;
			}
			BuildingList = new List<Building>();
			TotalBuildings = 0;
			for (int i = 0; i < PictureBoxList.Count; i++)
			{
				if (PictureBoxList[i].BackColor != Color.Green)
				{
					BorGsIndex = r.Next(1, 4);
					if (BorGsIndex == 1)
					{
						Price = r.Next(20000, 25000);
						BuildingList.Add(new Building(PictureBoxList[i], Price, false, false, 1, null, TotalBuildings++));
					}
					if (BorGsIndex == 2)
					{
						Price = r.Next(30000, 45000);
						BuildingList.Add(new Building(PictureBoxList[i], Price, false, false, 3, null, TotalBuildings++));
					}
					if (BorGsIndex == 3)
					{
						Price = r.Next(50000, 75000);
						BuildingList.Add(new Building(PictureBoxList[i], Price, false, false, 2, null, TotalBuildings++));
					}
					progressBar1.PerformStep();
				}
			}
		}

		#region Butons and Menus
		private void QuitGameBtn_Click(object sender, EventArgs e)
		{
			AvQGPanel.Visible = true;
			Timeflow.Enabled = false;
		}

		private void newGamItem_Click(object sender, EventArgs e)
		{
			AvNGPanel.Visible = true;
			Timeflow.Enabled = false;
		}

		private void QuitGameItem_Click(object sender, EventArgs e)
		{
			AvQGPanel.Visible = true;
			Timeflow.Enabled = false;
		}

		private void NewGameBtn_Click(object sender, EventArgs e)
		{
			NewGameMenu.Visible = true;
			StartMenu.Visible = false;
			Timeflow.Enabled = false;
		}

		private void StartBtn_Click(object sender, EventArgs e)
		{
			progressBar1.Visible = true;
			progressBar1.Maximum = 100;
			progressBar1.Step = 1;
			progressBar1.PerformStep();
			QuitGameBtn.Visible = true;
			MoneyDisplaylabel.Visible = true;
			Moneylabel.Visible = true;
			menuStrip1.Visible = true;
			GameMenu.Visible = true;
			NewGameMenu.Visible = false;
			progressBar1.Step = 6;
			owner = new Player(PNameTextBox.Text, ColorChooser(), Money = InitialMoneyChooser(), OwnerProps);
			PlayersListBoard.Items.Add(owner.Name);
			MoneyDisplaylabel.Text = owner.Money.ToString();
			//generate map
			progressBar1.PerformStep();
			PictureBoxList.Clear();
			BuildingList.Clear();
			MapGenerator();
			progressBar1.PerformStep();
			progressBar1.Visible = false;
			Timeflow.Enabled = true;
			flowing = 0;
			Flowinglbl.Visible = true;

		}

		private int InitialMoneyChooser()
		{
			if (InitialMoneyComboBox.SelectedIndex == 0)
				return Money = 50000;
			if (InitialMoneyComboBox.SelectedIndex == 1)
				return Money = 75000;
			if (InitialMoneyComboBox.SelectedIndex == 2)
				return Money = 100000;
			if (InitialMoneyComboBox.SelectedIndex == 3)
				return Money = 150000;
			else
				return 1000000;
		}

		private Color ColorChooser()
		{
			if (PlayerColorComboBox.SelectedIndex == 0)
				return Color.Blue;
			if (PlayerColorComboBox.SelectedIndex == 1)
				return Color.Black;
			if (PlayerColorComboBox.SelectedIndex == 2)
				return Color.Green;
			if (PlayerColorComboBox.SelectedIndex == 3)
				return Color.Yellow;
			else
				return Color.Blue;
		}

		private void BuyColorChanger(Building item)
		{
			if ((owner.PlayerColor == Color.Blue) && (item.IndexImg == 1))
				item.PB.BackgroundImage = LandLord.Properties.Resources._1x1_Blue;
			if ((owner.PlayerColor == Color.Blue) && (item.IndexImg == 2))
				item.PB.BackgroundImage = LandLord.Properties.Resources._1x2_Blue;
			if ((owner.PlayerColor == Color.Blue) && (item.IndexImg == 3))
				item.PB.BackgroundImage = LandLord.Properties.Resources._2x1_Blue;
			if ((owner.PlayerColor == Color.Black) && (item.IndexImg == 1))
				item.PB.BackgroundImage = LandLord.Properties.Resources._1x1_Black;
			if ((owner.PlayerColor == Color.Black) && (item.IndexImg == 2))
				item.PB.BackgroundImage = LandLord.Properties.Resources._1x2_Black;
			if ((owner.PlayerColor == Color.Black) && (item.IndexImg == 3))
				item.PB.BackgroundImage = LandLord.Properties.Resources._2x1_Black;
			if ((owner.PlayerColor == Color.Green) && (item.IndexImg == 1))
				item.PB.BackgroundImage = LandLord.Properties.Resources._1x1_Green;
			if ((owner.PlayerColor == Color.Green) && (item.IndexImg == 2))
				item.PB.BackgroundImage = LandLord.Properties.Resources._1x2_Green;
			if ((owner.PlayerColor == Color.Green) && (item.IndexImg == 3))
				item.PB.BackgroundImage = LandLord.Properties.Resources._2x1_Green;
			if ((owner.PlayerColor == Color.Yellow) && (item.IndexImg == 1))
				item.PB.BackgroundImage = LandLord.Properties.Resources._1x1_Yellow;
			if ((owner.PlayerColor == Color.Yellow) && (item.IndexImg == 2))
				item.PB.BackgroundImage = LandLord.Properties.Resources._1x2_Yellow;
			if ((owner.PlayerColor == Color.Yellow) && (item.IndexImg == 3))
				item.PB.BackgroundImage = LandLord.Properties.Resources._2x1_Yellow;

		}

		private void SellColorChanger(Building item)
		{
			if (item.IndexImg == 1)
				item.PB.BackgroundImage = LandLord.Properties.Resources._1x1_White;
			if (item.IndexImg == 2)
				item.PB.BackgroundImage = LandLord.Properties.Resources._1x2_White;
			if (item.IndexImg == 3)
				item.PB.BackgroundImage = LandLord.Properties.Resources._2x1_White;
		}

		void Grass_Click(object sender, EventArgs e)
		{
			PictureBox clickedPictureBox = sender as PictureBox;
			foreach (var item in PictureBoxList)
			{
				DecisionBuyPanel.Visible = false;
				item.BorderStyle = BorderStyle.FixedSingle;
			}
		}

		void Building_Click(object sender, EventArgs e)
		{
			PictureBox clickedBuilding = sender as PictureBox;
			foreach (var item in BuildingList)
				if (item.PB == clickedBuilding)
				{
					DecisionSuccessBoughtPanel.Visible = false;
					DecisionSuccessSoldPanel.Visible = false;
					DecisionNoMoneyPanel.Visible = false;
					item.IsClicked = true;
					item.PB.BorderStyle = BorderStyle.Fixed3D;
					if (!item.IsBought)
					{
						DecisionBuyPanel.Visible = true;
						BuildingBuyValueLbl.Text = item.price.ToString();
						DecisionSellPanel.Visible = false;
					}
					else
					{
						DecisionBuyPanel.Visible = false;
						DecisionSellPanel.Visible = true;
						BuildingActualPriceLbl.Text = item.price.ToString();
						BuildingSellValueLbl.Text = ((int)(item.price) * 0.9).ToString();
					}
				}
				else
					item.PB.BorderStyle = BorderStyle.FixedSingle;
		}

		private void QGLeaveBtn_Click(object sender, EventArgs e)
		{
			QuitGameBtn.Visible = false;
			MoneyDisplaylabel.Visible = false;
			GameMenu.Visible = false;
			DecisionSuccessBoughtPanel.Visible = false;
			DecisionSuccessSoldPanel.Visible = false;
			DecisionBuyPanel.Visible = false;
			DecisionSellPanel.Visible = false;
			menuStrip1.Visible = false;
			WONpanel.Visible = false;
			AvQGPanel.Visible = false;
			StartMenu.Visible = true;
			for (int i = 0; i < BorGsL - 5; i++)
				for (int j = 0; j < BorGsL; j++)
					BorGs[i, j].Visible = false;
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			AvQGPanel.Visible = false;
			Timeflow.Enabled = true;
			WONpanel.Visible = false;
		}

		private void NGLeaveBtn_Click(object sender, EventArgs e)
		{
			QuitGameBtn.Visible = false;
			MoneyDisplaylabel.Visible = false;
			GameMenu.Visible = false;
			DecisionSuccessBoughtPanel.Visible = false;
			DecisionSuccessSoldPanel.Visible = false;
			DecisionBuyPanel.Visible = false;
			DecisionSellPanel.Visible = false;
			Moneylabel.Visible = false;
			menuStrip1.Visible = false;
			AvNGPanel.Visible = false;
			NewGameMenu.Visible = true;
			for (int i = 0; i < BorGsL - 5; i++)
				for (int j = 0; j < BorGsL; j++)
					BorGs[i, j].Visible = false;
		}

		private void NGCancelBtn_Click(object sender, EventArgs e)
		{
			AvNGPanel.Visible = false;
			Timeflow.Enabled = true;
		}

		private void BuyBtn_Click(object sender, EventArgs e)
		{
			foreach (var item in BuildingList)
			{
				if ((item.IsClicked) && (item.PB.BorderStyle == BorderStyle.Fixed3D))
				{
					item.IsClicked = false;
					if (owner.Money >= item.price)
					{
						item.IsBought = true;
						item.IsClicked = false;
						owner.Money -= item.price;
						BuyColorChanger(item);
						OwnerLbl1.Text = owner.Name;
						item.Owner = owner;
						OwnerProps.Add(item);
						DecisionSuccessBoughtPanel.Visible = true;
						DecisionNoMoneyPanel.Visible = false;
						DecisionSuccessSoldPanel.Visible = false;
						DecisionBuyPanel.Visible = false;
					}
					else
						DecisionNoMoneyPanel.Visible = true;
				}
			}
			int All = owner.PlayerProps.Count;
			if (All == 0.5 * TotalBuildings)
			{
				WONpanel.Visible = true;
				textBox50.Visible = true;
				textBoxYW.Visible = false;
			}
			if (All == TotalBuildings)
			{
				textBox50.Visible = false;
				Timeflow.Enabled = false;
				textBoxYW.Visible = true;
				WONpanel.Visible = true;
				AvQGPanel.Visible = true;
			}
			MoneyDisplaylabel.Text = owner.Money.ToString();
		}

		private void ExitAppBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SellBtn_Click(object sender, EventArgs e)
		{
			foreach (var item in BuildingList)
				if (item.IsClicked && item.IsBought && (item.PB.BorderStyle == BorderStyle.Fixed3D))
				{
					item.IsBought = false;
					item.IsClicked = false;
					SellColorChanger(item);
					owner.Money = owner.Money + (int)(0.9 * item.price);
					item.Owner = null;
					DecisionSuccessBoughtPanel.Visible = false;
					DecisionSuccessSoldPanel.Visible = true;
					DecisionSellPanel.Visible = false;
					OwnerLbl2.Text = "Nobody";
				}
			MoneyDisplaylabel.Text = owner.Money.ToString();
		}

		private void CentralBoard_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void PlayersListBoard_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void SearchPlayerBtn_Click(object sender, EventArgs e)
		{
			CentralBoard.Clear();
			CentralBoard.View = View.List;
			if (PlayersListBoard.Text == owner.Name)
			{
				CentralBoard.Items.Add("Name: " + owner.Name);
				CentralBoard.Items.Add("Money: " + owner.Money);
				CentralBoard.Items.Add("# of Buildings: " + owner.PlayerProps.Count);
				int value = 0;
				foreach (Building props in owner.PlayerProps)
					value += props.price;
				CentralBoard.Items.Add("Value of the empire: " + value);
			}

		}


		#endregion

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			Building.DrawSize = 55;
			InitialMoneyComboBox.Items.Add(50000);
			InitialMoneyComboBox.Items.Add(75000);
			InitialMoneyComboBox.Items.Add(100000);
			InitialMoneyComboBox.Items.Add(150000);
			InitialMoneyComboBox.SelectedIndex = 2;
			PlayerColorComboBox.Items.Add("Blue");
			PlayerColorComboBox.Items.Add("Black");
			PlayerColorComboBox.Items.Add("Green");
			PlayerColorComboBox.Items.Add("Yellow");
			PlayerColorComboBox.SelectedIndex = 0;
			PNameTextBox.Text = "Player1";
			flowing = 0;
			Flowinglbl.Text = flowing.ToString();
		}

		private void Timeflow_Tick(object sender, EventArgs e)
		{
			flowing++;
			int Timposit, Trent;
			Flowinglbl.Text = flowing.ToString();
			Trent = 0;
			foreach (Building item in BuildingList)
				if ((item.PB.BackColor != Color.Green) && (item.Owner != null))
				{
					Rent = (int)(item.price * 0.005);
					item.Owner.Money += Rent;
					MoneyDisplaylabel.Text = owner.Money.ToString();
					DecisionSuccessSoldPanel.Visible = false;
					DecisionSuccessBoughtPanel.Visible = false;
					DecisionNoMoneyPanel.Visible = false;
					Trent += Rent;
				}
			RenttextBox.Clear();
			RenttextBox.Text += "+" + Trent.ToString();
			if (flowing % 7 == 0)
			{
				Timposit = 0;
				foreach (Building item in BuildingList)
					if ((item.PB.BackColor != Color.Green) && (item.Owner != null))
					{
						Imposit = (int)(r.Next(20, 51) * 0.3 * item.Owner.PlayerProps.Count);
						item.Owner.Money -= Imposit;
						MoneyDisplaylabel.Text = owner.Money.ToString();
						DecisionBuyPanel.Visible = false;
						DecisionSellPanel.Visible = false;
						WONpanel.Visible = false;
						Timposit += Imposit;
					}
				Timposit /= 7;
				ImpositstextBox.Text += "-" + Timposit.ToString() + "\r\n";
			}
			if (flowing % 30 == 0)
			{
				RenttextBox.Clear();
				ImpositstextBox.Clear();
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
		public static SolidColorBrush brush = new SolidColorBrush(Color.FromRgb(0, 176, 0));
		public Player owner;
		private List<Building> OwnerProps = new List<Building>();
		public static Random r = new Random();
		public static int Price;
		public static int BorGsL = 26;
		public List<Building> BuildingList = new List<Building>();
		public List<Canvas> CanvasList = new List<Canvas>();
		public int BorGsItem;
		public int BorGsIndex;
		public Canvas[,] BorGs = new Canvas[BorGsL, BorGsL];
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
					Image image = new Image();
					resx += Building.DrawSize;
					BorGs[i, j] = new Canvas();
					Canvas.SetTop(image, resx);
					Canvas.SetLeft(image, resy);
					BorGs[i, j].Name = "Img" + i.ToString();
					BorGsItem = r.Next(0, 10);
					if (BorGsItem >= 2)
					{
						BorGsIndex = r.Next(1, 4);
						if (BorGsIndex == 1)
						{
							Assembly asm = Assembly.GetExecutingAssembly();
							Stream iconStream = asm.GetManifestResourceStream("1x1-White.png");
							PngBitmapDecoder iconDecoder = new PngBitmapDecoder(iconStream, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
							ImageSource iconSource = iconDecoder.Frames[0];
							image.Source = iconSource;
							image.Stretch = Stretch.Fill;
						}
						if (BorGsIndex == 2)
						{
							Assembly asm = Assembly.GetExecutingAssembly();
							Stream iconStream = asm.GetManifestResourceStream("1x2-White.png");
							PngBitmapDecoder iconDecoder = new PngBitmapDecoder(iconStream, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
							ImageSource iconSource = iconDecoder.Frames[0];
							image.Source = iconSource;
							image.Stretch = Stretch.Fill;
						}
						if (BorGsIndex == 3)
						{
							Assembly asm = Assembly.GetExecutingAssembly();
							Stream iconStream = asm.GetManifestResourceStream("2x1-White.png");
							PngBitmapDecoder iconDecoder = new PngBitmapDecoder(iconStream, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
							ImageSource iconSource = iconDecoder.Frames[0];
							image.Source = iconSource;
							image.Stretch = Stretch.Fill;
						}
					}
					else
					{
						BorGs[i, j].Background = brush;
						BorGs[i, j].Visibility = Visibility.Visible;
					}
					if (BorGsItem >= 2)
					{
						BorGs[i, j].MouseLeftButtonUp += new MouseButtonEventHandler(Building_Click);
					}
					else
					{
						BorGs[i, j].MouseLeftButtonUp += new MouseButtonEventHandler(Grass_Click);
					}
					BorGs[i, j].Children.Add(image);
					this.AddChild(BorGs[i, j]);
					CanvasList.Add(BorGs[i, j]);
					progressBar1.PerformStep();
				}
				resx = 400;
				resy += Building.DrawSize;
			}
			BuildingList = new List<Building>();
			TotalBuildings = 0;
			for (int i = 0; i < CanvasList.Count; i++)
			{
				if (CanvasList[i].Background != brush)
				{
					BorGsIndex = r.Next(1, 4);
					if (BorGsIndex == 1)
					{
						Price = r.Next(20000, 25000);
						BuildingList.Add(new Building(CanvasList[i], Price, false, false, 1, null, TotalBuildings++));
					}
					if (BorGsIndex == 2)
					{
						Price = r.Next(30000, 45000);
						BuildingList.Add(new Building(CanvasList[i], Price, false, false, 3, null, TotalBuildings++));
					}
					if (BorGsIndex == 3)
					{
						Price = r.Next(50000, 75000);
						BuildingList.Add(new Building(CanvasList[i], Price, false, false, 2, null, TotalBuildings++));
					}
					progressBar1.PerformStep();
				}
			}
		}

		#region Butons and Menus
		private void QuitGameBtn_Click(object sender, EventArgs e)
		{
			AvQGPanel.Visibility = Visibility.Visible;
			Timeflow.Enabled = false;
		}

		private void newGamItem_Click(object sender, EventArgs e)
		{
			AvNGPanel.Visibility = Visibility.Visible;
			Timeflow.Enabled = false;
		}

		private void QuitGameItem_Click(object sender, EventArgs e)
		{
			AvQGPanel.Visibility = Visibility.Visible;
			Timeflow.Enabled = false;
		}

		private void NewGameBtn_Click(object sender, EventArgs e)
		{
			NewGameMenu.Visibility = Visibility.Visible;
			StartMenu.Visibility = Visibility.Hidden;
			Timeflow.Enabled = false;
		}

		private void StartBtn_Click(object sender, EventArgs e)
		{
			progressBar1.Visibility = Visibility.Visible;
			progressBar1.Maximum = 100;
			progressBar1.Step = 1;
			progressBar1.PerformStep();
			QuitGameBtn.Visibility = Visibility.Visible;
			MoneyDisplaylabel.Visibility = Visibility.Visible;
			Moneylabel.Visibility = Visibility.Visible;
			GameMenu.Visibility = Visibility.Visible;
			NewGameMenu.Visibility = Visibility.Hidden;
			progressBar1.Step = 6;
			owner = new Player(PNameTextBox.Text, ColorChooser(), Money = InitialMoneyChooser(), OwnerProps);
			PlayersListBoard.Items.Add(owner.Name);
			MoneyDisplaylabel.Text = owner.Money.ToString();
			//generate map
			progressBar1.PerformStep();
			CanvasList.Clear();
			BuildingList.Clear();
			MapGenerator();
			progressBar1.PerformStep();
			progressBar1.Visibility = Visibility.Hidden;
			Timeflow.Enabled = true;
			flowing = 0;
			Flowinglbl.Visibility = Visibility.Visible;

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
				item.IMG.BackgroundCanvas = CityLord.Properties.Resources._1x1_Blue;
			if ((owner.PlayerColor == Color.Blue) && (item.IndexImg == 2))
				item.IMG.BackgroundCanvas = CityLord.Properties.Resources._1x2_Blue;
			if ((owner.PlayerColor == Color.Blue) && (item.IndexImg == 3))
				item.IMG.BackgroundCanvas = CityLord.Properties.Resources._2x1_Blue;
			if ((owner.PlayerColor == Color.Black) && (item.IndexImg == 1))
				item.IMG.BackgroundCanvas = CityLord.Properties.Resources._1x1_Black;
			if ((owner.PlayerColor == Color.Black) && (item.IndexImg == 2))
				item.IMG.BackgroundCanvas = CityLord.Properties.Resources._1x2_Black;
			if ((owner.PlayerColor == Color.Black) && (item.IndexImg == 3))
				item.IMG.BackgroundCanvas = CityLord.Properties.Resources._2x1_Black;
			if ((owner.PlayerColor == Color.Green) && (item.IndexImg == 1))
				item.IMG.BackgroundCanvas = CityLord.Properties.Resources._1x1_Green;
			if ((owner.PlayerColor == Color.Green) && (item.IndexImg == 2))
				item.IMG.BackgroundCanvas = CityLord.Properties.Resources._1x2_Green;
			if ((owner.PlayerColor == Color.Green) && (item.IndexImg == 3))
				item.IMG.BackgroundCanvas = CityLord.Properties.Resources._2x1_Green;
			if ((owner.PlayerColor == Color.Yellow) && (item.IndexImg == 1))
				item.IMG.BackgroundCanvas = CityLord.Properties.Resources._1x1_Yellow;
			if ((owner.PlayerColor == Color.Yellow) && (item.IndexImg == 2))
				item.IMG.BackgroundCanvas = CityLord.Properties.Resources._1x2_Yellow;
			if ((owner.PlayerColor == Color.Yellow) && (item.IndexImg == 3))
				item.IMG.BackgroundCanvas = CityLord.Properties.Resources._2x1_Yellow;

		}

		private void SellColorChanger(Building item)
		{
			if (item.IndexImg == 1)
				item.IMG.BackgroundCanvas = CityLord.Properties.Resources._1x1_White;
			if (item.IndexImg == 2)
				item.IMG.BackgroundCanvas = CityLord.Properties.Resources._1x2_White;
			if (item.IndexImg == 3)
				item.IMG.BackgroundCanvas = CityLord.Properties.Resources._2x1_White;
		}

		void Grass_Click(object sender, EventArgs e)
		{
			Canvas clickedCanvas = sender as Canvas;
			foreach (var item in CanvasList)
			{
				DecisionBuyPanel.Visibility = Visibility.Hidden;
				item.BorderStyle = BorderStyle.FixedSingle;
			}
		}

		void Building_Click(object sender, EventArgs e)
		{
			Canvas clickedBuilding = sender as Canvas;
			foreach (var item in BuildingList)
				if (item.IMG == clickedBuilding)
				{
					DecisionSuccessBoughtPanel.Visibility = Visibility.Hidden;
					DecisionSuccessSoldPanel.Visibility = Visibility.Hidden;
					DecisionNoMoneyPanel.Visibility = Visibility.Hidden;
					item.IsClicked = true;
					item.IMG.BorderStyle = BorderStyle.Fixed3D;
					if (!item.IsBought)
					{
						DecisionBuyPanel.Visibility = Visibility.Visible;
						BuildingBuyValueLbl.Text = item.price.ToString();
						DecisionSellPanel.Visibility = Visibility.Hidden;
					}
					else
					{
						DecisionBuyPanel.Visibility = Visibility.Hidden;
						DecisionSellPanel.Visibility = Visibility.Visible;
						BuildingActualPriceLbl.Text = item.price.ToString();
						BuildingSellValueLbl.Text = ((int)(item.price) * 0.9).ToString();
					}
				}
				else
					item.IMG.BorderStyle = BorderStyle.FixedSingle;
		}

		private void QGLeaveBtn_Click(object sender, EventArgs e)
		{
			QuitGameBtn.Visibility = Visibility.Hidden;
			MoneyDisplaylabel.Visibility = Visibility.Hidden;
			GameMenu.Visibility = Visibility.Hidden;
			DecisionSuccessBoughtPanel.Visibility = Visibility.Hidden;
			DecisionSuccessSoldPanel.Visibility = Visibility.Hidden;
			DecisionBuyPanel.Visibility = Visibility.Hidden;
			DecisionSellPanel.Visibility = Visibility.Hidden;
			WONpanel.Visibility = Visibility.Hidden;
			AvQGPanel.Visibility = Visibility.Hidden;
			StartMenu.Visibility = Visibility.Visible;
			for (int i = 0; i < BorGsL - 5; i++)
				for (int j = 0; j < BorGsL; j++)
					BorGs[i, j].Visibility = Visibility.Hidden;
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			AvQGPanel.Visibility = Visibility.Hidden;
			Timeflow.Enabled = true;
			WONpanel.Visibility = Visibility.Hidden;
		}

		private void NGLeaveBtn_Click(object sender, EventArgs e)
		{
			QuitGameBtn.Visibility = Visibility.Hidden;
			MoneyDisplaylabel.Visibility = Visibility.Hidden;
			GameMenu.Visibility = Visibility.Hidden;
			DecisionSuccessBoughtPanel.Visibility = Visibility.Hidden;
			DecisionSuccessSoldPanel.Visibility = Visibility.Hidden;
			DecisionBuyPanel.Visibility = Visibility.Hidden;
			DecisionSellPanel.Visibility = Visibility.Hidden;
			Moneylabel.Visibility = Visibility.Hidden;
			AvNGPanel.Visibility = Visibility.Hidden;
			NewGameMenu.Visibility = Visibility.Visible;
			for (int i = 0; i < BorGsL - 5; i++)
				for (int j = 0; j < BorGsL; j++)
					BorGs[i, j].Visibility = Visibility.Hidden;
		}

		private void NGCancelBtn_Click(object sender, EventArgs e)
		{
			AvNGPanel.Visibility = Visibility.Hidden;
			Timeflow.Enabled = true;
		}

		private void BuyBtn_Click(object sender, EventArgs e)
		{
			foreach (var item in BuildingList)
			{
				if ((item.IsClicked) && (item.IMG.BorderStyle == BorderStyle.Fixed3D))
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
						DecisionSuccessBoughtPanel.Visibility = Visibility.Visible;
						DecisionNoMoneyPanel.Visibility = Visibility.Hidden;
						DecisionSuccessSoldPanel.Visibility = Visibility.Hidden;
						DecisionBuyPanel.Visibility = Visibility.Hidden;
					}
					else
						DecisionNoMoneyPanel.Visibility = Visibility.Visible;
				}
			}
			int All = owner.PlayerProps.Count;
			if (All == 0.5 * TotalBuildings)
			{
				WONpanel.Visibility = Visibility.Visible;
				textBox50.Visibility = Visibility.Visible;
				textBoxYW.Visibility = Visibility.Hidden;
			}
			if (All == TotalBuildings)
			{
				textBox50.Visibility = Visibility.Hidden;
				Timeflow.Enabled = false;
				textBoxYW.Visibility = Visibility.Visible;
				WONpanel.Visibility = Visibility.Visible;
				AvQGPanel.Visibility = Visibility.Visible;
			}
			MoneyDisplaylabel.Text = owner.Money.ToString();
		}

		private void ExitApIMGtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SellBtn_Click(object sender, EventArgs e)
		{
			foreach (var item in BuildingList)
				if (item.IsClicked && item.IsBought && (item.IMG.BorderStyle == BorderStyle.Fixed3D))
				{
					item.IsBought = false;
					item.IsClicked = false;
					SellColorChanger(item);
					owner.Money = owner.Money + (int)(0.9 * item.price);
					item.Owner = null;
					DecisionSuccessBoughtPanel.Visibility = Visibility.Hidden;
					DecisionSuccessSoldPanel.Visibility = Visibility.Visible;
					DecisionSellPanel.Visibility = Visibility.Hidden;
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
			//ViewBase view = new ViewBase();
			//CentralBoard.View = view;
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
				if ((item.IMG.BackColor != Color.Green) && (item.Owner != null))
				{
					Rent = (int)(item.price * 0.005);
					item.Owner.Money += Rent;
					MoneyDisplaylabel.Text = owner.Money.ToString();
					DecisionSuccessSoldPanel.Visibility = Visibility.Hidden;
					DecisionSuccessBoughtPanel.Visibility = Visibility.Hidden;
					DecisionNoMoneyPanel.Visibility = Visibility.Hidden;
					Trent += Rent;
				}
			RenttextBox.Clear();
			RenttextBox.Text += "+" + Trent.ToString();
			if (flowing % 7 == 0)
			{
				Timposit = 0;
				foreach (Building item in BuildingList)
					if ((item.IMG.BackColor != Color.Green) && (item.Owner != null))
					{
						Imposit = (int)(r.Next(20, 51) * 0.3 * item.Owner.PlayerProps.Count);
						item.Owner.Money -= Imposit;
						MoneyDisplaylabel.Text = owner.Money.ToString();
						DecisionBuyPanel.Visibility = Visibility.Hidden;
						DecisionSellPanel.Visibility = Visibility.Hidden;
						WONpanel.Visibility = Visibility.Hidden;
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

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
using System.Windows.Threading;

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

		public static DispatcherTimer Timeflow;
		public int Money;
		public static Color green = Color.FromRgb(0, 176, 0);
		public static Color black = Color.FromRgb(0, 0, 0);
		public static Color blue = Color.FromRgb(0, 62, 206);
		public static Color yellow = Color.FromRgb(232, 240, 0);
		public static SolidColorBrush greenBrush = new SolidColorBrush(green);
		public static SolidColorBrush blackBrush = new SolidColorBrush(black);
		public static SolidColorBrush blueBrush = new SolidColorBrush(blue);
		public static SolidColorBrush yellowBrush = new SolidColorBrush(yellow);
		public Player owner;
		private List<Building> OwnerProps = new List<Building>();
		public static Random r = new Random();
		public static int Price;
		public static int BorGsL = 26;
		public List<Building> BuildingList = new List<Building>();
		public List<Button> ButtonList = new List<Button>();
		public int BorGsItem;
		public int BorGsIndex;
		public Button[,] BorGs = new Button[BorGsL, BorGsL];
		public int flowing;
		public int TotalMapItems;
		public int TotalBuildings;
		public int Rent;
		public int Imposit;

		public void MapGenerator()
		{
			int resx = -750;
			int resy = -450;
			TotalMapItems = 0;
			Grid grid = this.ButonInsider as Grid;
			for (int i = 0; i < BorGsL - 9; i++)
			{
				for (int j = 0; j < BorGsL; j++)
				{
					TotalMapItems++;
					ImageBrush image = new ImageBrush();
					resx += Building.DrawSize;
					BorGs[i, j] = new Button();
					BorGs[i, j].Margin = new Thickness(resx * 2, resy * 2, 0, 0);
					BorGs[i, j].Name = "Img" + i.ToString();
					BorGs[i, j].Height = Building.DrawSize;
					BorGs[i, j].Width = Building.DrawSize;
					BorGsItem = r.Next(0, 10);
					if (BorGsItem >= 2)
					{
						BorGsIndex = r.Next(1, 4);
						if (BorGsIndex == 1)
						{
							image.ImageSource = new BitmapImage(new Uri(@"../../resources/_1x1_White.bmp", UriKind.Relative));
							BorGs[i, j].Background = image;
							image.Stretch = Stretch.Fill;
							BorGs[i, j].Visibility = Visibility.Visible;
						}
						else if (BorGsIndex == 2)
						{
							image.ImageSource = new BitmapImage(new Uri(@"../../resources/_1x2_White.bmp", UriKind.Relative));
							BorGs[i, j].Background = image;
							image.Stretch = Stretch.Fill;
							BorGs[i, j].Visibility = Visibility.Visible;
						}
						else if (BorGsIndex == 3)
						{
							image.ImageSource = new BitmapImage(new Uri(@"../../resources/_2x1_White.bmp", UriKind.Relative));
							BorGs[i, j].Background = image;
							image.Stretch = Stretch.Fill;
							BorGs[i, j].Visibility = Visibility.Visible;
						}
					}
					else
					{
						BorGs[i, j].Background = greenBrush;
						BorGs[i, j].Visibility = Visibility.Visible;
					}
					if (BorGsItem >= 2)
					{
						BorGs[i, j].MouseLeftButtonUp += Building_Click;
					}
					else
					{
						BorGs[i, j].MouseLeftButtonUp += Grass_Click;
					}
					grid.Children.Add(BorGs[i, j]);
					ButtonList.Add(BorGs[i, j]);
					progressBar1.Value++;
				}
				resx = -750;
				resy += Building.DrawSize;
			}
			BuildingList = new List<Building>();
			TotalBuildings = 0;
			for (int i = 0; i < ButtonList.Count; i++)
			{
				if (ButtonList[i].Background != greenBrush)
				{
					BorGsIndex = r.Next(1, 4);
					if (BorGsIndex == 1)
					{
						Price = r.Next(20000, 25000);
						BuildingList.Add(new Building(ButtonList[i], Price, false, false, 1, null, TotalBuildings++));
					}
					else if (BorGsIndex == 2)
					{
						Price = r.Next(30000, 45000);
						BuildingList.Add(new Building(ButtonList[i], Price, false, false, 3, null, TotalBuildings++));
					}
					else if (BorGsIndex == 3)
					{
						Price = r.Next(50000, 75000);
						BuildingList.Add(new Building(ButtonList[i], Price, false, false, 2, null, TotalBuildings++));
					}
					progressBar1.Value++;
				}
			}
		}

		#region Butons and Menus

		private void QuitGameBtn_Click(object sender, EventArgs e)
		{
			AvQGPanel.Visibility = Visibility.Visible;
			Timeflow.Stop();
		}

		private void NewGameBtn_Click(object sender, EventArgs e)
		{
			NewGameMenu.Visibility = Visibility.Visible;
			StartMenu.Visibility = Visibility.Hidden;
		}

		private void StartBtn_Click(object sender, EventArgs e)
		{
			progressBar1.Visibility = Visibility.Visible;
			progressBar1.Maximum = 100;
			progressBar1.Value = 1;
			progressBar1.Value = 3;
			QuitGameBtn.Visibility = Visibility.Visible;
			MoneyDisplaylabel.Visibility = Visibility.Visible;
			Moneylabel.Visibility = Visibility.Visible;
			GameMenu.Visibility = Visibility.Visible;
			NewGameMenu.Visibility = Visibility.Hidden;
			progressBar1.Value = 6;
			owner = new Player(PNameTextBox.Text, ColorChooser(), Money = InitialMoneyChooser(), OwnerProps);
			CentralBoard.Items.Clear();
			PlayersListBoard.Items.Clear();
			PlayersListBoard.Items.Add(owner.Name);
			MoneyDisplaylabel.Content = owner.Money.ToString();
			
			//generate map
			progressBar1.Value = 10;
			ButtonList.Clear();
			BuildingList.Clear();
			ButonInsider.Visibility = Visibility.Visible;
			MapGenerator();
			progressBar1.Value = 99;
			progressBar1.Visibility = Visibility.Hidden;
			Timeflow = new DispatcherTimer();
			Timeflow.Tick += Timeflow_Tick;
			Timeflow.Interval = new TimeSpan(0, 0, 1);
			Timeflow.Start();
			flowing = 0;
			Flowinglbl.Visibility = Visibility.Visible;
			progressBar1.Value = 100;
		}

		void Grass_Click(object sender, MouseButtonEventArgs e)
		{
			DecisionBuyPanel.Visibility = Visibility.Hidden;
		}

		void Building_Click(object sender, MouseButtonEventArgs e)
		{
			Button clickedBuilding = sender as Button;
			foreach (var item in BuildingList)
			{
				if (item.IMG == clickedBuilding)
				{
					DecisionSuccessBoughtPanel.Visibility = Visibility.Hidden;
					DecisionSuccessSoldPanel.Visibility = Visibility.Hidden;
					DecisionNoMoneyPanel.Visibility = Visibility.Hidden;
					item.IsClicked = true;
					if (!item.IsBought)
					{
						DecisionBuyPanel.Visibility = Visibility.Visible;
						BuildingBuyValueLbl.Content = item.price.ToString();
						DecisionSellPanel.Visibility = Visibility.Hidden;
					}
					else
					{
						DecisionBuyPanel.Visibility = Visibility.Hidden;
						DecisionSellPanel.Visibility = Visibility.Visible;
						BuildingActualPriceLbl.Content = item.price.ToString();
						BuildingSellValueLbl.Content = (item.price * 0.9).ToString();
					}
				}
			}
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
			ButonInsider.Visibility = Visibility.Hidden;
			for (int i = 0; i < BorGsL - 9; i++)
			{
				for (int j = 0; j < BorGsL; j++)
				{
					BorGs[i, j].Visibility = Visibility.Hidden;
				}
			}
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
			ButonInsider.Visibility = Visibility.Hidden;
			for (int i = 0; i < BorGsL - 5; i++)
			{
				for (int j = 0; j < BorGsL; j++)
				{
					BorGs[i, j].Visibility = Visibility.Hidden;
				}
			}
		}

		private void NGCancelBtn_Click(object sender, EventArgs e)
		{
			AvNGPanel.Visibility = Visibility.Hidden;
			Timeflow.Start();
		}

		private void BuyBtn_Click(object sender, EventArgs e)
		{
			foreach (var item in BuildingList)
			{
				if ((item.IsClicked))
				{
					item.IsClicked = false;
					if (owner.Money >= item.price)
					{
						item.IsBought = true;
						item.IsClicked = false;
						owner.Money -= item.price;
						BuyColorChanger(item);
						OwnerLbl1.Content = owner.Name;
						item.Owner = owner;
						OwnerProps.Add(item);
						DecisionSuccessBoughtPanel.Visibility = Visibility.Visible;
						DecisionNoMoneyPanel.Visibility = Visibility.Hidden;
						DecisionSuccessSoldPanel.Visibility = Visibility.Hidden;
						DecisionBuyPanel.Visibility = Visibility.Hidden;
					}
					else
					{
						DecisionNoMoneyPanel.Visibility = Visibility.Visible;
					}
				}
			}
			int All = owner.PlayerProps.Count;
			if (All == 0.5 * TotalBuildings)
			{
				WONpanel.Visibility = Visibility.Visible;
				textBox50.Visibility = Visibility.Visible;
				textBoxYW.Visibility = Visibility.Hidden;
			}
			else if (All == TotalBuildings)
			{
				textBox50.Visibility = Visibility.Hidden;
				Timeflow.Stop();
				textBoxYW.Visibility = Visibility.Visible;
				WONpanel.Visibility = Visibility.Visible;
				AvQGPanel.Visibility = Visibility.Visible;
			}
			MoneyDisplaylabel.Content = owner.Money.ToString();
		}

		private void ExitAppBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SellBtn_Click(object sender, EventArgs e)
		{
			foreach (var item in BuildingList)
			{
				if (item.IsClicked && item.IsBought)
				{
					item.IsBought = false;
					item.IsClicked = false;
					SellColorChanger(item);
					owner.Money = owner.Money + (int)(0.9 * item.price);
					item.Owner = null;
					DecisionSuccessBoughtPanel.Visibility = Visibility.Hidden;
					DecisionSuccessSoldPanel.Visibility = Visibility.Visible;
					DecisionSellPanel.Visibility = Visibility.Hidden;
					OwnerLbl2.Content = "Nobody";
				}
			}
			MoneyDisplaylabel.Content = owner.Money.ToString();
		}

		private void SearchPlayerBtn_Click(object sender, EventArgs e)
		{
			CentralBoard.Items.Clear();
			if (PlayersListBoard.Text == owner.Name)
			{
				CentralBoard.Items.Add("Name: " + owner.Name);
				CentralBoard.Items.Add("Money: " + owner.Money);
				CentralBoard.Items.Add("# of Buildings: " + owner.PlayerProps.Count);
				int value = 0;
				foreach (Building props in owner.PlayerProps)
				{
					value += props.price;
				}
				CentralBoard.Items.Add("Value of the empire: " + value);
			}
		}

		private void QGCancelBtn_Click(object sender, RoutedEventArgs e)
		{
			AvQGPanel.Visibility = Visibility.Hidden;
			Timeflow.Start();
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
			Flowinglbl.Content = flowing.ToString();
		}

		private void Timeflow_Tick(object sender, EventArgs e)
		{
			flowing++;
			int Timposit, Trent;
			Flowinglbl.Content = flowing.ToString();
			Trent = 0;
			foreach (Building item in BuildingList)
			{
				if ((item.IMG.Background != greenBrush) && (item.Owner != null))
				{
					Rent = (int)(item.price * 0.005);
					item.Owner.Money += Rent;
					MoneyDisplaylabel.Content = owner.Money.ToString();
					DecisionSuccessSoldPanel.Visibility = Visibility.Hidden;
					DecisionSuccessBoughtPanel.Visibility = Visibility.Hidden;
					DecisionNoMoneyPanel.Visibility = Visibility.Hidden;
					Trent += Rent;
				}
			}
			RenttextBox.Clear();
			if (Trent > 0)
			{
				RenttextBox.Text += "+" + Trent.ToString();

			}
			else if (Trent == 0)
			{
				RenttextBox.Text += Trent.ToString();
			}
			else if (Trent < 0)
			{
				RenttextBox.Text += Trent.ToString();
			}

			if (flowing % 7 == 0)
			{
				Timposit = 0;
				foreach (Building item in BuildingList)
				{
					if ((item.IMG.Background != greenBrush) && (item.Owner != null))
					{
						Imposit = (int)(r.Next(20, 51) * 0.3 * item.Owner.PlayerProps.Count);
						item.Owner.Money -= Imposit;
						MoneyDisplaylabel.Content = owner.Money.ToString();
						DecisionBuyPanel.Visibility = Visibility.Hidden;
						DecisionSellPanel.Visibility = Visibility.Hidden;
						WONpanel.Visibility = Visibility.Hidden;
						Timposit += Imposit;
					}
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

		private int InitialMoneyChooser()
		{
			if (InitialMoneyComboBox.SelectedIndex == 0)
			{
				return Money = 50000;
			}
			else if (InitialMoneyComboBox.SelectedIndex == 1)
			{
				return Money = 75000;
			}
			else if (InitialMoneyComboBox.SelectedIndex == 2)
			{
				return Money = 100000;
			}
			else if (InitialMoneyComboBox.SelectedIndex == 3)
			{
				return Money = 150000;
			}
			else
			{
				return 1000000;
			}
		}

		private Color ColorChooser()
		{
			if (PlayerColorComboBox.SelectedIndex == 0)
			{
				return blue;
			}
			else if (PlayerColorComboBox.SelectedIndex == 1)
			{
				return black;
			}
			else if (PlayerColorComboBox.SelectedIndex == 2)
			{
				return green;
			}
			else if (PlayerColorComboBox.SelectedIndex == 3)
			{
				return yellow;
			}
			else
			{
				return blue;
			}
		}

		private void BuyColorChanger(Building item)
		{
			ImageBrush image = new ImageBrush();
			if ((owner.PlayerColor == blue) && (item.IndexImg == 1))
			{
				image.ImageSource = new BitmapImage(new Uri("../../resources/_1x1_Blue.bmp", UriKind.Relative));
				item.IMG.Background = image;
			}
			else if ((owner.PlayerColor == blue) && (item.IndexImg == 2))
			{
				image.ImageSource = new BitmapImage(new Uri("../../resources/_1x2_Blue.bmp", UriKind.Relative));
				item.IMG.Background = image;
			}
			else if ((owner.PlayerColor == blue) && (item.IndexImg == 3))
			{
				image.ImageSource = new BitmapImage(new Uri("../../resources/_2x1_Blue.bmp", UriKind.Relative));
				item.IMG.Background = image;
			}
			else if ((owner.PlayerColor == black) && (item.IndexImg == 1))
			{
				image.ImageSource = new BitmapImage(new Uri("../../resources/_1x1_Black.bmp", UriKind.Relative));
				item.IMG.Background = image;
			}
			else if ((owner.PlayerColor == black) && (item.IndexImg == 2))
			{
				image.ImageSource = new BitmapImage(new Uri("../../resources/_1x2_Black.bmp", UriKind.Relative));
				item.IMG.Background = image;
			}
			else if ((owner.PlayerColor == black) && (item.IndexImg == 3))
			{
				image.ImageSource = new BitmapImage(new Uri("../../resources/_2x1_Black.bmp", UriKind.Relative));
				item.IMG.Background = image;
			}
			else if ((owner.PlayerColor == green) && (item.IndexImg == 1))
			{
				image.ImageSource = new BitmapImage(new Uri("../../resources/_1x1_Green.bmp", UriKind.Relative));
				item.IMG.Background = image;
			}
			else if ((owner.PlayerColor == green) && (item.IndexImg == 2))
			{
				image.ImageSource = new BitmapImage(new Uri("../../resources/_1x2_Green.bmp", UriKind.Relative));
				item.IMG.Background = image;
			}
			else if ((owner.PlayerColor == green) && (item.IndexImg == 3))
			{
				image.ImageSource = new BitmapImage(new Uri("../../resources/_2x1_Green.bmp", UriKind.Relative));
				item.IMG.Background = image;
			}
			else if ((owner.PlayerColor == yellow) && (item.IndexImg == 1))
			{
				image.ImageSource = new BitmapImage(new Uri("../../resources/_1x1_Yellow.bmp", UriKind.Relative));
				item.IMG.Background = image;
			}
			else if ((owner.PlayerColor == yellow) && (item.IndexImg == 2))
			{
				image.ImageSource = new BitmapImage(new Uri("../../resources/_1x2_Yellow.bmp", UriKind.Relative));
				item.IMG.Background = image;
			}
			else if ((owner.PlayerColor == yellow) && (item.IndexImg == 3))
			{
				image.ImageSource = new BitmapImage(new Uri("../../resources/_2x1_Yellow.bmp", UriKind.Relative));
				item.IMG.Background = image;
			}
		}

		private void SellColorChanger(Building item)
		{
			ImageBrush image = new ImageBrush();
			if (item.IndexImg == 1)
			{
				image.ImageSource = new BitmapImage(new Uri("../../resources/_1x1_White.bmp", UriKind.Relative));
				image.Stretch = Stretch.Fill;
				item.IMG.Background = image;
			}
			else if (item.IndexImg == 2)
			{
				image.ImageSource = new BitmapImage(new Uri("../../resources/_1x2_White.bmp", UriKind.Relative));
				image.Stretch = Stretch.Fill;
				item.IMG.Background = image;
			}
			else if (item.IndexImg == 3)
			{
				image.ImageSource = new BitmapImage(new Uri("../../resources/_2x1_White.bmp", UriKind.Relative));
				image.Stretch = Stretch.Fill;
				item.IMG.Background = image;
			}
		}
	}
}

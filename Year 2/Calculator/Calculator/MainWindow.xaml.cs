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

namespace Calculator
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public static double Sum = 0;
		public static double Imp = 0;
		public static char[] numerics = {'0','1','2','3','4','5','6', '7', '8', '9'};
		public static char[] calculTokens = {'+', '-', '*', '/'};
		public static char[] specialTokens = { '(', ')', '.'};
		public static bool EqualClicked = false;
		public static int count = 0;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void BtnClear_Click(object sender, RoutedEventArgs e)
		{
			tbResultor.Clear();
			tbCountWither.Clear();
			tbCalculToken.Clear();
			Sum = 0;
			Imp = 0;
		}

		private void Window_KeyDown(object sender, KeyEventArgs e)
		{
			tbResultor.Text += ValidateKey(e.Key.ToString());
		}

		private string ValidateKey(string text)
		{
			string aux = "";
			foreach (char item in text)
			{
				if (item == '0' ||
					item == '1' ||
					item == '2' ||
					item == '3' ||
					item == '4' ||
					item == '5' ||
					item == '6' ||
					item == '7' ||
					item == '8' ||
					item == '9' ||
					item == '(' ||
					item == ')' ||
					item == '/' ||
					item == '*' ||
					item == '-' ||
					item == '+' ||
					item == '.')
				{
					aux += item;
				}
			}
			return text = aux;
		}

		private void BtnKey1_Click(object sender, RoutedEventArgs e)
		{
			Checker("1");
		}

		private void BtnKey2_Click(object sender, RoutedEventArgs e)
		{
			Checker("2");
		}

		private void BtnKey3_Click(object sender, RoutedEventArgs e)
		{
			Checker("3");
		}

		private void BtnKey4_Click(object sender, RoutedEventArgs e)
		{
			Checker("4");
		}

		private void BtnKey5_Click(object sender, RoutedEventArgs e)
		{
			Checker("5");
		}

		private void BtnKey6_Click(object sender, RoutedEventArgs e)
		{
			Checker("6");
		}

		private void BtnKey7_Click(object sender, RoutedEventArgs e)
		{
			Checker("7");
		}

		private void BtnKey8_Click(object sender, RoutedEventArgs e)
		{
			Checker("8");
		}

		private void BtnKey9_Click(object sender, RoutedEventArgs e)
		{
			Checker("9");
		}

		private void BtnKey0_Click(object sender, RoutedEventArgs e)
		{
			Checker("0");
		}

		private void BtnClearLast_Click(object sender, RoutedEventArgs e)
		{
			if (tbResultor.Text.Length > 0)
			{
				string resAux = tbResultor.Text;
				resAux = resAux.Substring(0, resAux.Length - 1);
				tbResultor.Text = resAux;
			}
		}

		public void compute(int count)
		{
			if (true)
			{

			}
			switch (count)
			{
				case 1:
					Sum = Sum - double.Parse(tbResultor.Text);
					tbResultor.Text = tbResultor.Text.ToString();
					break;
				case 2:
					Sum = Sum + double.Parse(tbResultor.Text);
					tbResultor.Text = tbResultor.Text.ToString();
					break;
				case 3:
					Sum = Sum * double.Parse(tbResultor.Text);
					tbResultor.Text = tbResultor.Text.ToString();
					break;
				case 4:
					Sum = Imp / double.Parse(tbResultor.Text);
					tbResultor.Text = tbResultor.Text.ToString();
					break;
				default:
					break;
			}
			count = 0;
		}

		private void Checker(string KeyValue)
		{
			if (count != 0)
			{
				tbCountWither.Text += tbResultor.Text + " " + tbCalculToken.Text + " ";
				tbResultor.Clear();
			}
			tbCalculToken.Clear();
			if (EqualClicked)
			{
				tbResultor.Clear();
				EqualClicked = false;
			}
			tbResultor.Text += KeyValue;
		}

		private void BtnEqual_Click(object sender, RoutedEventArgs e)
		{
			if (tbResultor.Text != "")
			{
				compute(count);
			}
			tbResultor.Text = Sum.ToString();
			tbCalculToken.Clear();
			tbCountWither.Clear();
			Sum = 0;
			Imp = 0;
			EqualClicked = true;
		}

		private void BtnKeyPlus_Click(object sender, RoutedEventArgs e)
		{
			count = 2;
			tbCalculToken.Text = "+";
			compute(count);
		}

		private void BtnMinus_Click(object sender, RoutedEventArgs e)
		{
			count = 1;
			tbCalculToken.Text = "-";
			compute(count);
		}

		private void BtnInmultire_Click(object sender, RoutedEventArgs e)
		{
			if (Sum == 0)
			{
				Sum = 1;
			}
			count = 3;
			tbCalculToken.Text = "*";
			compute(count);
		}

		private void BtnImpartire_Click(object sender, RoutedEventArgs e)
		{
			if (Imp == 0)
			{
				Imp = Convert.ToDouble(tbResultor.Text);
			}
			else
			{
				compute(count);
			}
			count = 4;
			tbCalculToken.Text = "/";
		}
	}
}


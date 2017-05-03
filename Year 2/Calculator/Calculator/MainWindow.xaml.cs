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
		public static double NumericClicked = -1;
		public static bool EqualClicked = false;
		public static bool NumericToken = false;
		public static bool CalculToken = false;
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
			NumericToken = false;
			CalculToken = false;
			Sum = 0;
			count = 0;
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
				if (tbResultor.Text.Length - 1 > 0)
				{
					NumericToken = true;
				}
				else
				{
					NumericToken = false;
				}
			}
		}

		public void compute(int count)
		{
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
			CalculToken = false;
		}

		private void Checker(string KeyValue)
		{
			NumericClicked = Convert.ToDouble(KeyValue);
			if (EqualClicked)
			{
				tbCountWither.Clear();
				tbResultor.Clear();
				tbCalculToken.Clear();
				EqualClicked = false;
			}
			tbResultor.Text += KeyValue;
			NumericToken = true;
		}

		private void CalculusChecker()
		{
			if (tbResultor.Text != "")
			{
				if (CalculToken)
				{
					//if (tbCalculToken.Text == "-")
					//{
					//	if (tbCountWither.Text == "")
					//	{
					//		tbCountWither.Text += " " + tbCalculToken.Text + tbResultor.Text + " ";
					//	}
					//}
					//else
					//{
						tbCountWither.Text += tbResultor.Text + " " + tbCalculToken.Text + " ";
					//}
				}
				else if (!CalculToken)
				{
					tbCountWither.Text += tbResultor.Text + " " + tbCalculToken.Text + " ";
				}
				//else if (NumericToken && CalculToken)
				//{
				//	tbCountWither.Text += tbResultor.Text + " ";
				//}
				//else if (NumericToken && !CalculToken)
				//{
				//	tbCountWither.Text += tbResultor.Text + " ";
				//}
			}
			else if (tbCountWither.Text == "" && tbResultor.Text == "")
			{
				tbCountWither.Text = "-";
				//tbCountWither.Text += tbResultor.Text + " ";
			}
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
			NumericToken = false;
			NumericClicked = -1;
			count = 0;
			Sum = 0;
			Imp = 0;
			EqualClicked = true;
		}

		private void BtnKeyPlus_Click(object sender, RoutedEventArgs e)
		{
			count = 2;
			CalculToken = true;
			NumericToken = false;
			tbCalculToken.Text = "+";
			CalculusChecker();
			if (tbCountWither.Text != "+")
			{
				compute(count);
			}
			tbResultor.Clear();
			NumericClicked = -1;
		}

		private void BtnMinus_Click(object sender, RoutedEventArgs e)
		{
			count = 1;
			CalculToken = true;
			NumericToken = false;
			tbCalculToken.Text = "-";
			CalculusChecker();
			if (tbCountWither.Text != "-")
			{
				compute(count);
			}
			tbResultor.Clear();
			NumericClicked = -1;
		}

		private void BtnInmultire_Click(object sender, RoutedEventArgs e)
		{
			if (Sum == 0)
			{
				Sum = 1;
			}
			count = 3;
			CalculToken = true;
			NumericToken = false;
			tbCalculToken.Text = "*";
			CalculusChecker();
			if (tbCountWither.Text != "*")
			{
				compute(count);
			}
			tbResultor.Clear();
			NumericClicked = -1;
		}

		private void BtnImpartire_Click(object sender, RoutedEventArgs e)
		{
			if (Imp == 0)
			{
				Imp = Convert.ToDouble(tbResultor.Text);
			}
			else
			{
				if (tbCountWither.Text != "/")
				{
					compute(count);
				}
			}
			count = 4;
			CalculToken = true;
			NumericToken = false;
			tbCalculToken.Text = "/";
			CalculusChecker();
			tbResultor.Clear();
			NumericClicked = -1;
		}

		private void BtnPeriod_Click(object sender, EventArgs e)
		{
			int c = tbResultor.Text.Length;
			int flag = 0;
			string text = tbResultor.Text;
			for (int i = 0; i < c; i++)
			{
				if (text[i].ToString() == ".")
				{
					flag = 1; break;
				}
				else
				{
					flag = 0;
				}
			}
			if (flag == 0)
			{
				tbResultor.Text = tbResultor.Text + ".";
			}
		}

	}
}


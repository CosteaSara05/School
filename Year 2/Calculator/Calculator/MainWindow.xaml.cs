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
		public MainWindow()
		{
			InitializeComponent();
		}

		private void BtnClear_Click(object sender, RoutedEventArgs e)
		{
			Resultor.Clear();
		}

		private void Window_KeyDown(object sender, KeyEventArgs e)
		{
			Resultor.Text += ValidateKey(e.Key.ToString());
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
			Resultor.Text += "1";
		}

		private void BtnKey2_Click(object sender, RoutedEventArgs e)
		{
			Resultor.Text += "2";
		}

		private void BtnKey3_Click(object sender, RoutedEventArgs e)
		{
			Resultor.Text += "3";
		}

		private void BtnKey4_Click(object sender, RoutedEventArgs e)
		{
			Resultor.Text += "4";
		}

		private void BtnKey5_Click(object sender, RoutedEventArgs e)
		{
			Resultor.Text += "5";
		}

		private void BtnKey6_Click(object sender, RoutedEventArgs e)
		{
			Resultor.Text += "6";
		}

		private void BtnKey7_Click(object sender, RoutedEventArgs e)
		{
			Resultor.Text += "7";
		}

		private void BtnKey8_Click(object sender, RoutedEventArgs e)
		{
			Resultor.Text += "8";
		}

		private void BtnKey9_Click(object sender, RoutedEventArgs e)
		{
			Resultor.Text += "9";
		}

		private void BtnKey0_Click(object sender, RoutedEventArgs e)
		{
			Resultor.Text += "0";
		}
	}
}

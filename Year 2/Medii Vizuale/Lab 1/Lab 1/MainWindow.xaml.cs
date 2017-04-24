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

namespace Lab_1
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

		private string ValidateText(string text)
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
					item == '9')
				{
					aux += item;
				}
			}
			return text = aux;
		}


		private void btnResult_Click(object sender, RoutedEventArgs e)
		{
			if (String.IsNullOrEmpty(tbFirstNumber.Text) && String.IsNullOrEmpty(tbSecondNumber.Text))
			{
				MessageBox.Show("Empty lines. Cannot proceed");
			}
			else
			{
				double x = -Convert.ToDouble(tbFirstNumber.Text) / Convert.ToDouble(tbSecondNumber.Text);
				MessageBox.Show("Result is: " + x);
			}
		}

		private void tbFirstNumber_TextChanged(object sender, TextChangedEventArgs e)
		{
			tbFirstNumber.Text = ValidateText(tbFirstNumber.Text);
		}

		private void tbSecondNumber_TextChanged(object sender, TextChangedEventArgs e)
		{
			tbSecondNumber.Text = ValidateText(tbSecondNumber.Text);
		}
	}
}

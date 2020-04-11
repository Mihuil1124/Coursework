using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MD4
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{
			if (md4.IsChecked == true)
			{
				if (this.inputPanel.Text.Length != 0)
				{
					EnityMD4 createrHashCode = new EnityMD4();
					this.outputPanel.Text = createrHashCode.GetHexHashFromString(this.inputPanel.Text);
				}
			} else 
			{
				if (this.inputPanel.Text.Length != 0)
				{
					this.outputPanel.Text = EntityMD5.Calculate(this.inputPanel.Text);
				}
			}

			
		}
	}
}

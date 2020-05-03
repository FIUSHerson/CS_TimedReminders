using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CS_TimedReminders.Windows
{
    /// <summary>
    /// Interaction logic for AddElement.xaml
    /// </summary>
    public partial class AddElement : Window
    {
        public AddElement()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cancel_MouseDown(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("test");
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("test");
        }
    }
}

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

namespace HelloWpf
{
    /// <summary>
    /// Logique d'interaction pour GoodbyeWindow.xaml
    /// </summary>
    public partial class GoodbyeWindow : Window
    {
        public GoodbyeWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = null;

            try
            {
                s.Trim();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("A handled exception just occurred: " + ex.Message, "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            }


            s.Trim();
            
        }
    }
}

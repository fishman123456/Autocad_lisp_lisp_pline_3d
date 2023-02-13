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

namespace Autocad_lisp_lisp_pline_3d
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

      

        private void t_0_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void butt_2_0_Click(object sender, RoutedEventArgs e)
        {
            t_0.Text = string.Empty;
        }
        private void t_1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void butt_2_1_Click(object sender, RoutedEventArgs e)
        {
            t_1.Text = string.Empty;
        }
        private void t_2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void butt_2_2_Click(object sender, RoutedEventArgs e)
        {
            t_2.Text = string.Empty;
        }

        private void butt_3_Click(object sender, RoutedEventArgs e)
        {
            t_0.Text = string.Empty;
            t_1.Text = string.Empty;
            t_2.Text = string.Empty;
        }

        private void butt_0_2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

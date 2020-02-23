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

namespace DrLitovs837pGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string selectedFileFormat = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void radioButton_Copy_Checked(object sender, RoutedEventArgs e)
        {
            selectedFileFormat = "Google Sheets";
        }

        private void radioButton_Copy1_Checked(object sender, RoutedEventArgs e)
        {
            selectedFileFormat = "Local Excel";
        }
    }
}

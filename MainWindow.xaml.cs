using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
        string selectedFileFormat;
        string recordsFilePath;

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

        private void buttonSelectLocalFile_Click(object sender, RoutedEventArgs e)
        {
            // create an object to handle grabbing a file
            OpenFileDialog localFileLocation = new OpenFileDialog();
            if (localFileLocation.ShowDialog() == true)
            {
                recordsFilePath = localFileLocation.FileName;
                labelConsoleOutput.Content = recordsFilePath;
            }
            
        }
    }
}

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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace DrLitovs837pGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string selectedFileFormat;
        string recordsFilePath;
        string outputPath;

        public MainWindow()
        {
            InitializeComponent();
            gridInputSelection.Visibility = Visibility.Visible;
        }

        private void radioButton_Copy_Checked(object sender, RoutedEventArgs e)
        {
            selectedFileFormat = "Remote";
            gridInputSelection.Visibility = Visibility.Hidden;
        }

        private void radioButton_Copy1_Checked(object sender, RoutedEventArgs e)
        {
            selectedFileFormat = "Local";

            //if (gridInputSelection.Visibility == Visibility.Hidden)
            //{
            //    gridInputSelection.Visibility = Visibility.Visible;
            //}
        }

        private void buttonSelectLocalFile_Click(object sender, RoutedEventArgs e)
        {
            // create an object to handle grabbing a file
            Microsoft.Win32.OpenFileDialog localFileLocation = new Microsoft.Win32.OpenFileDialog();
            // add filter for excel files
            localFileLocation.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            // check if the windows file selector is launched
            if (localFileLocation.ShowDialog() == true)
            {
                // pass the path of the file to the recordsFilePath string
                recordsFilePath = localFileLocation.FileName;
                labelSelectFile.Content = recordsFilePath;
            }
            
        }

        private void buttonSelectOutputFolder_Click(object sender, RoutedEventArgs e)
        {
            // create a CommonOpenFileDialog object to grab the file path
            CommonOpenFileDialog outputFolderPath = new CommonOpenFileDialog();
            outputFolderPath.IsFolderPicker = true;
            if (outputFolderPath.ShowDialog() == CommonFileDialogResult.Ok)
            {
                // pass the folder path to outputFolderPath string
                outputPath = outputFolderPath.FileName + "\\";
                labelSelectOutput.Content = outputPath;
            }
        }
    }
}

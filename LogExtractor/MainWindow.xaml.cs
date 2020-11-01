using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace LogExtractor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FileTextHandling filehandling = new FileTextHandling();
        string _sourceFileName;
        public MainWindow()


        {
            InitializeComponent();
              
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void radioBtn_ExtractAfter(object sender, RoutedEventArgs e)
        {
            int t = 1;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string modifiedText;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                 _sourceFileName = openFileDialog.FileName;
                modifiedText = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_Run_Click(object sender, RoutedEventArgs e)
        {
            string RegExTxt = this.rexExpTextBox.Text;

            if (radiobutton_extract_before.IsChecked==true)
            {

            }
            if (radiobutton_extract_after.IsChecked == true)
            {
                filehandling.matchRegExAfter(RegExTxt, _sourceFileName);
            }
            if (radiobutton_extract_this.IsChecked == true)
            {

            }
            if (radiobutton_extract_remove_duplicates.IsChecked == true)
            {

            }

            MessageBox.Show("Finished Extracting", "Log Extractor");
        }

        private void btn_SaveAs_Click(object sender, RoutedEventArgs e)
        {
            string ExtractedAfter = _sourceFileName + "_Extracted_After.txt";
            filehandling.SaveToLog(ExtractedAfter);
            MessageBox.Show("Finished Saving Extracted File", "Log Extractor");

        }
    }

        //private void btn_SaveAs_Click(object sender, RoutedEventArgs e)
        //{
        ////using (System.IO.StreamWriter file =
        ////new System.IO.StreamWriter(@"\Users\gadif\Documents\SPIRA_PLUGIN\PlatinumDriveSmoke\SQALAB2\SQALAB2_Shell_TraceLog-EXTRACTED2", true))
        ////{
        ////    foreach (string line in extractedTTxt)
        ////    {
        ////        file.WriteLine(line);
        ////    }
        ////}
        //Console.WriteLine("save as..");
        //}
    }


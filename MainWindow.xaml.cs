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

namespace FileReadExample
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

        private void btnReadFile_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("Names.txt");
                lblOuptut.Content = "";
                while (!sr.EndOfStream)
                {
                    lblOuptut.Content += sr.ReadLine() + Environment.NewLine;
                }//end while
            }//end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//end catch
        }

        private void btnReadFile2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader("bl2.txt");
                lblOuptut.Content = "";
                string output = "";
                while (!sr.EndOfStream)
                {
                    string FullName = sr.ReadLine();
                    string[] Names = FullName.Split(new char[] { ',' });
                    output += Names[1] + Environment.NewLine;
                }//end while
                lblOuptut.Content = output;
            }//end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//end catch
        }
    }
}
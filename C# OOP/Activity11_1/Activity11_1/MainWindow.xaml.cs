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

namespace Activity11_1
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

        private void MemoViewer_Loaded(object sender, RoutedEventArgs e)
        {
            sbTextbox1.Text = "Ready to load file";
            sbTextbox2.Text = DateTime.Today.ToShortDateString();
        }

        private void mnuOpen_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Document";
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (.txt)|*.txt";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                string fileName = dlg.FileName;
                TextRange range;
                System.IO.FileStream fStream;
                if (System.IO.File.Exists(fileName))
                {
                    range = new TextRange(rtbMemo.Document.ContentStart, rtbMemo.Document.ContentEnd);
                    fStream = new System.IO.FileStream(fileName, System.IO.FileMode.OpenOrCreate);
                    range.Load(fStream, System.Windows.DataFormats.Text);
                    fStream.Close();
                }
                sbTextbox1.Text = fileName;
            }
        }

        private void mnuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

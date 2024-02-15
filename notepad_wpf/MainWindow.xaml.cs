using Microsoft.Win32;
using System;
using System.IO;
using System.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace notepad_wpf
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
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var pituus = textBox.Text.Length;
            statusPituus.Content = pituus.ToString();
        }
        private void FontStyleMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Window1 fontSettingsWindow = new Window1();
            fontSettingsWindow.Owner = this;
            fontSettingsWindow.ShowDialog();
        }
        private void AvaaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string fileName = openFileDialog.FileName;
                textBox.Text = File.ReadAllText(fileName);
            }
        }

        private void TallennaNimellaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                string fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, textBox.Text);
            }
        }

        private void TulostaMenuItem_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                FlowDocument document = new FlowDocument(new Paragraph(new Run(textBox.Text)));
                printDialog.PrintDocument(((IDocumentPaginatorSource)document).DocumentPaginator, "Printing from WPF App");
            }
        }
        private void MainWindow_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                textBox.Text += (string)e.Data.GetData(DataFormats.Text);
            }
        }
    }
}

﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
    }
}
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
using System.Windows.Shapes;

namespace notepad_wpf
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            // Apply font settings to MainWindow
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            double fontSize;
            if (double.TryParse(fontSizeTextBox.Text, out fontSize))
            {
                mainWindow.textBox.FontSize = fontSize;
            }

            mainWindow.textBox.FontStyle = (boldCheckBox.IsChecked == true) ? FontStyles.Normal : FontStyles.Italic;
            mainWindow.textBox.FontStyle = (italicCheckBox.IsChecked == true) ? FontStyles.Italic : mainWindow.textBox.FontStyle;

            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

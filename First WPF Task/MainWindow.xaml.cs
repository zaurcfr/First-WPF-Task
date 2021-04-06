using System;
using System.Collections.Generic;
using System.Globalization;
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


namespace First_WPF_Task
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

        
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)random.Next(0, 256), (byte)random.Next(0, 256), (byte)random.Next(0, 256)));
            if (sender is Button button)
            {
                button.Background = brush;
                Title = button.Content.ToString();
                System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml(brush.ToString());
                MessageBox.Show($"I am button No_{button.Content}\nMy hex code: {brush}\nMy ARGB {color}");
            }
        }

        private void btn_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button button)
            {
                button.Visibility = Visibility.Hidden;
                Title = button.Content.ToString();
            }
        }
    }
}

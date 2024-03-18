using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Workshop_Orai_5_Client
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
        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CreateButtons();
        }
        public void CreateButtons()
        {
            for (int i = 0; i < 16; i++)
            {
                Button button = new Button()
                {
                    HorizontalAlignment = HorizontalAlignment.Stretch,
                    VerticalContentAlignment = VerticalAlignment.Top,
                    Content = $"{i + 1}",
                    Margin = new Thickness(5),
                    BorderBrush = new SolidColorBrush(Colors.White),
                    Background = new SolidColorBrush(Colors.LightGreen)
                };
                Grid.SetColumn(button, i % 4);
                Grid.SetRow(button, i / 4);
                grid.Children.Add(button);
            }
        }
    }
}
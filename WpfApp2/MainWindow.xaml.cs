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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string CorrectPassword = "123456";

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as System.Windows.Controls.Button;
            if (button != null && InputField != null)
            {
                InputField.Text += button.Content.ToString();
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            InputField.Text = string.Empty;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (InputField.Text == CorrectPassword)
                MessageBox.Show("Пароль верный!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                MessageBox.Show("Неверный пароль!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            InputField.Text = string.Empty;
        }
    }
}
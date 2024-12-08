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

namespace WpfApp3
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

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double[,] matrix = new double[3, 3]
                {
                    { double.Parse(Cell00.Text), double.Parse(Cell01.Text), double.Parse(Cell02.Text) },
                    { double.Parse(Cell10.Text), double.Parse(Cell11.Text), double.Parse(Cell12.Text) },
                    { double.Parse(Cell20.Text), double.Parse(Cell21.Text), double.Parse(Cell22.Text) }
                };

                double rezult = CalculateDeterminant(matrix);
                ResultBox.Text = $"= {rezult:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private double CalculateDeterminant(double[,] matrix)
        {
            return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])* matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0]) + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
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

namespace ZadanieTabControl
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
        private void DetailsCalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string expression = DetailsCalculatorTextBox.Text;
                double result = EvaluateExpression(expression);
                MessageBox.Show($"Wynik: {result}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Błąd: {ex.Message}");
            }
        }

        private double EvaluateExpression(string expression)
        {
            string wrappedExpression = $"({expression})";

            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), wrappedExpression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);

            double result = double.Parse((string)row["expression"]);

            return result;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ok");
        }
    }
}

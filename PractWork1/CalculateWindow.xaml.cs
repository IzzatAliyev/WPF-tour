using System.Windows;

namespace PractWork1
{
    /// <summary>
    /// Interaction logic for CalculateWindow.xaml
    /// </summary>
    public partial class CalculateWindow : Window
    {
        public CalculateWindow()
        {
            InitializeComponent();
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ExecuteCalculation(object sender, RoutedEventArgs e)
        {
            try
            {
                var valueC = float.TryParse(ValueOfC.Text, out var valueOfC) ? valueOfC : throw new Exception("Variable c is not a number !!!");
                var valueD = float.TryParse(ValueOfD.Text, out var valueOfD) ? valueOfD : throw new Exception("Variable d is not a number !!!");
                var sum = 2 * valueC + valueD;
                ResultValue.Text = sum.ToString();
                ResultName.Visibility = Visibility.Visible;
                ResultValue.Visibility = Visibility.Visible;
                CloseButton.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

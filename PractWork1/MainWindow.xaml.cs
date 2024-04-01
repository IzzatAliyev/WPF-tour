using System.Windows;

namespace PractWork1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public string Button1IsActive { get; set; } =  "Button 1 is active"; 
    public string Button2IsActive { get; set; } = "Button 2 is active";

    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;
    }

    //обробка подій натискання на кнопки
    private void Btn_1_Click(object sender, RoutedEventArgs e)
    {
        // MessageBox.Show("Button 1 clicked");
        Btn_2.Focus();
        Lbl_inf.Content = Button2IsActive;
    }
    private void Btn_2_Click(object sender, RoutedEventArgs e)
    {
        Btn_1.Focus();
        Lbl_inf.Content = Button1IsActive;
    }
    //обробка події завантаження вікна
    private void Win_Lab1_Loaded(object sender, RoutedEventArgs e)
    {
        Btn_1.Focus();
    }
}
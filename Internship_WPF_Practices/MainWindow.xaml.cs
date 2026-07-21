using System.Windows;

namespace Internship_WPF_Practices
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("Coluld not open file", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error); // Mesaj Kutusunu açar

            MessageBox.Show("Could not open file");

            MessageBoxResult result = MessageBox.Show("Could not open file", "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error); // Mesaj kutusu kapatıldığında, mesaj kutusunun sonucunu result değişkenine atar.
            // "OK" düğmesine basılmayıp pencere kapatılırsa, sonucumuz yine "OK" olacaktır.

            MessageBoxResult result2 = MessageBox.Show("Do you agree?", "Agreement", MessageBoxButton.YesNo, MessageBoxImage.Question);
            // mesaj kutusu kapatılana kadar hiçbir şey çalışmaya devam etmeyecektir

            if(result2 == MessageBoxResult.Yes)
            {
                tbInfo.Text = "Agreed";
            }
            else
            {
                tbInfo.Text = "Not Agreed";
            }

        }
    }
}
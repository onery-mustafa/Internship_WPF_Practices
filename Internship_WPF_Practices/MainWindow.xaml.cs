using System.Windows;
using Internship_WPF_Practices.View;

namespace Internship_WPF_Practices
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            // Burada yapmamız gereken ilk şey, normal pencerenin bir örneğini oluşturmak.
            NormalWindow NormalWindow = new NormalWindow();
            NormalWindow.Show(); //NormalWindow u gösteriyoruz.
         }

        private void btnMoal_Click(object sender, RoutedEventArgs e)
        {

            ModalWindow ModalWindow = new ModalWindow();
            ModalWindow.ShowDialog();

            if(ModalWindow.Success)  txtInput.Text = ModalWindow.Input;
            
        }
    }
}
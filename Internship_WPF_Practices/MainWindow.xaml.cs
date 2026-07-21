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
            MessageBox.Show("Coluld not open file", "ERROR!"); // Mesaj Kutusunu açar
        }
    }
}
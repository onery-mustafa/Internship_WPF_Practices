using Microsoft.Win32;
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
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.ShowDialog(); // bu metot, dosya açma iletişim kutusunu gösterir ve kullanıcı bir dosya seçene kadar bekler

        }
    }
}
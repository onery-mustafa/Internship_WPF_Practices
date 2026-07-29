using System.Windows;
using System.Collections;

namespace Internship_WPF_Practices
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this; // (bu, veri bağlamı olacak olan arka plan kodudur. Böylece koleksiyon girişlerini nerede bulacağını bilir. 
            InitializeComponent();
 
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
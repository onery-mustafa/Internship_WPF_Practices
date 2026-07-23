using System.Windows;

namespace Internship_WPF_Practices
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            ExpanderDetails.IsExpanded = !ExpanderDetails.IsExpanded;  // Bu bir özelliktir. true veya false olarak ayarlanabilir. 
        }
    }
}
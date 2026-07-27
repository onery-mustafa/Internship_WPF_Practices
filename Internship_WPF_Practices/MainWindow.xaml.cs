using System.Windows;

namespace Internship_WPF_Practices
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Starting.Text = "ROBOCAM PLUS";
            Thread.Sleep(1000);
            Starting.Text = "TEZMAKSAN";

        }
    }
}
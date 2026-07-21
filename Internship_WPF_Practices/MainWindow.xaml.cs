using System.Windows;

namespace Internship_WPF_Practices
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();

        }

        private string boundText;

        public string BoundText
        {
            get { return boundText; }

            set
            {
                boundText = value;
                // OnPropertyChanged();

            }
        }
    }
}
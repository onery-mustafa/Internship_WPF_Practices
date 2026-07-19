using System.Windows;

namespace Internship_WPF_Practices
{
    public partial class MainWindow : Window
    {
        bool state = false;
        public MainWindow()
        {
            InitializeComponent();
            
            // ButtonState.Text = "Control Panel";
            // Button.Content = "Stop";

        }

        private void Click(object sender, RoutedEventArgs e)
        {
            if (state)
            {
                ButtonState.Text = "Stopped";
                Button.Content = "Start";
            }
            else
            {
                ButtonState.Text = "Running";
                Button.Content = "Stop";
            }

            state = !state;
        }
    }
}
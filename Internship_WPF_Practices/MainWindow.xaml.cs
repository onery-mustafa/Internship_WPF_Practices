using System.Windows;
using System.Windows.Threading;


namespace Internship_WPF_Practices
{
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

      
        }
        

        void timer_Tick(object sender, EventArgs e)
        {
           // timerView.Text = DateTime.Now.ToString("HH:mm:ss");

           // message.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red);
            
        }
    }
}
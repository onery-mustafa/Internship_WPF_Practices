using System.Windows;

namespace Internship_WPF_Practices
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
         // listeyi önceden doldurma:
        /*  InitializeComponent();
            IvEntries.Items.Add("A");
            IvEntries.Items.Add("B");
            IvEntries.Items.Add("C");
        */
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            IvEntries.Items.Add(txtEntry.Text);
            txtEntry.Clear();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int index = IvEntries.SelectedIndex; // Seçili öğenin indeksini al
            IvEntries.Items.RemoveAt(index); // Seçili öğeyi kaldır
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            IvEntries.Items.Clear();
        }

        
    }
}
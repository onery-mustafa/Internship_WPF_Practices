using System.Windows;
using System.Collections;

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
            // 1: tekli seçim. nesnenin dizi numarasını alma. 
            /*  int index = IvEntries.SelectedIndex; // Seçili öğenin indeksini al
                IvEntries.Items.RemoveAt(index); // Seçili öğeyi kaldır
             */

            // 2: tekli seçim. öğenin kendisini alma
            /*  object item = IvEntries.SelectedItem; // Seçili öğeyi seçili diziye tercih ederiz. çünkü öğenin kendisiyle işlem yapmak isteyebiliriz. öğenin ne olduğunu bilmemiz gereken bir uygulama yapabilliriz.
              var result = MessageBox.Show($"Are you sure you want to delete: {(string)item}", "Sure?", MessageBoxButton.YesNo ); // buradaki string koruma amaçlı. eğer öğe string değilse hata almamak için.
              if(result == MessageBoxResult.Yes) IvEntries.Items.Remove(item);
            */

            // 3: Çoklu seçim. öğenin kendisini alma.
            var items = IvEntries.SelectedItems;
            var result = MessageBox.Show($"Are you sure you want to delete {items.Count} items", "Sure?", MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes)
            {
                 var itemsList = new ArrayList(items);
                // var itemsList = items; //foreach ın içine items yazmış gibi yine hata alırız
                foreach (var item in itemsList) IvEntries.Items.Remove(item);
            }
           

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete all items?", "Sure", MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes) IvEntries.Items.Clear();

        }

        
    }
}
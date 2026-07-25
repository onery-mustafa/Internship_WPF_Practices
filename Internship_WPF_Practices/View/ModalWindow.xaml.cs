using System.Windows;

namespace Internship_WPF_Practices.View
{
    public partial class ModalWindow : Window
    {
        
        public bool Success { get; set; }
        public string Input { get; set; }
        public ModalWindow()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {

            Success = true; // OK düğmesine basılmazsa faslse olur
            Input = txtInput.Text;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtInput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            // Metin giriş alanındaki metin boş veya null değilse tamam düğmesi etkin, değilse pasif olmasını istiyoruz:
            if(!string.IsNullOrEmpty(txtInput.Text)) btnOK.IsEnabled = true;
            else btnOK.IsEnabled = false;
        }
    }
}

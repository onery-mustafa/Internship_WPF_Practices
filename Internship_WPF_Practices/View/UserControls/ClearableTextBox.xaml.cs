using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Internship_WPF_Practices.View.UserControls
{
    /// <summary>
    /// Interaction logic for ClearableTextBox.xaml
    /// </summary>
    public partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }

        private void btnClearClick(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus(); // kutu temizlendikten sonra imleci tekrar kutuya odaklamak için
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

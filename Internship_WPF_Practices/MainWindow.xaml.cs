using Microsoft.Win32;
using System.Windows;

namespace Internship_WPF_Practices
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            // FileDialog.ShowDialog(); // bu metot, dosya açma iletişim kutusunu gösterir ve kullanıcı bir dosya seçene kadar bekler

            FileDialog.Filter = "C# Source Files | *.cs"; // yalnızca .cs uzantılı dosyaları gösterir
            FileDialog.InitialDirectory = @"C:\Users\user\source\repos\Internship_WPF_Practices"; // başlangıç dizinini ayarlar
            FileDialog.Title = "Please pick CS Source file(s)..."; // iletişim kutusunun başlığını ayarlar
            FileDialog.Multiselect = true; // birden fazla dosya seçimi için

            bool? success = FileDialog.ShowDialog(); // kullanıcı bir dosya seçerse true döner

            if (success==true)
            {
                // string path = FileDialog.FileName; // seçilen dosyanın tam yolunu alır. tek dosya seçimi için
                // string FileName = FileDialog.SafeFileName; // seçilen dosyanın sadece adını alır. tek dosya seçimi için

                string[] paths = FileDialog.FileNames; // Çoklu dosya seçimi için
                string[] FileNames = FileDialog.SafeFileNames;

                // tbInfo.Text = path;
                // tbInfo.Text = FileName; // string FileName satırını kapattığımız için çalışmıyor
                tbInfo.Text = FileNames[2]; 
            }
            else
            {
                // didnt pick  anything. null değer alır?
            }

        }
    }
}
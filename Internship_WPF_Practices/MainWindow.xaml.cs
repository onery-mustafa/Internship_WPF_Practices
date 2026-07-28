using System.Windows;

namespace Internship_WPF_Practices
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this; // Veri bağlamı özelliği bu arka plan kod dosyasına ayarladık. 
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


/*
 
INotifyPropertyChanged Nedir ve Implementasyonu:
https://gokhan-gokalp.com/wpf-inotifypropertychanged-nedir-ve-implementasyonu/

https://canertosuner.com/post/inotifypropertychanged-nedir-nasil-kullanilir

C# Masterclass 1307 Dependency Properties
https://www.youtube.com/watch?v=jJZsSiVWDqE

https://www.yazilimkodlama.com/wpf/wpf-baslangicta-acilacak-formu-belirleme/#google_vignette

https://learn.microsoft.com/tr-tr/dotnet/desktop/wpf/data/how-to-implement-property-change-notification

*/
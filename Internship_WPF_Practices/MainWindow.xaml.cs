using System.Windows;
using System.ComponentModel;

namespace Internship_WPF_Practices
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            DataContext = this; // Veri bağlamı özelliğini bu arka plan kod dosyasına ayarladık. 
            InitializeComponent();

        }

        private string boundText;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string BoundText
        {
            get { return boundText; }

            set
            {
                boundText = value;
                OnPropertyChanged("BoundText");

                // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText"));
                // Yukarıdaki uzun kodu GUI miz büyümeye başladığında her seferinde yeniden yazmak yerine özellik değişikliği olayında başka bir yöntem (alt satırdaki isimle) oluşturabilir ve bu yöntemle olayımuzı çağırabiliriz.
                // OnPropertyChanged();


            }
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "set from code";
        }
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}


/*
 
INotifyPropertyChanged Nedir ve Implementasyonu:
https://gokhan-gokalp.com/wpf-inotifypropertychanged-nedir-ve-implementasyonu/

https://canertosuner.com/post/inotifypropertychanged-nedir-nasil-kullanilir

C# Masterclass 1307 Dependency Properties
https://www.youtube.com/watch?v=jJZsSiVWDqE

https://learn.microsoft.com/tr-tr/dotnet/desktop/wpf/data/how-to-implement-property-change-notification

*/
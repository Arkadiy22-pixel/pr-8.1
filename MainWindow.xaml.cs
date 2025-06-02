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

namespace Интерфейс_ИС_Домовой
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void labelPaswdRecovery_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            PaswdRecovery paswdRecovery = new PaswdRecovery();
            paswdRecovery.Show();
        }

        private void BtnLog_Click(object sender, RoutedEventArgs e)
        {
            AllApplications applications = new AllApplications();
            applications.Show();
            Close();
        }
    }
}
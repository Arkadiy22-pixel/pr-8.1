using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Интерфейс_ИС_Домовой
{
    /// <summary>
    /// Логика взаимодействия для PaswdRecovery.xaml
    /// </summary>
    public partial class PaswdRecovery : Window
    {
        public PaswdRecovery()
        {
            InitializeComponent();
        }

        private void BtnLog_Копировать_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ожидайте администратора", "Ожидание", MessageBoxButton.OK);
        }

        private void BtnLog_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("На вашу почту или номер телефона отправленна ссылка для восстановления", "Ожидание", MessageBoxButton.OK);
        }
    }
}

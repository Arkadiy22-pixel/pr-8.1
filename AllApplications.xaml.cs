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
    /// Логика взаимодействия для AllApplications.xaml
    /// </summary>
    public partial class AllApplications : Window
    {
        public AllApplications()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxFilter.SelectedItem is ComboBoxItem selectedItem)
            {
                string selectedValue = selectedItem.Tag as string;

                switch (selectedValue)
                {
                    case "По дате":
                        WindowDate windowDate = new WindowDate();
                        windowDate.Show(); 
                        break;
                    case "По статусу":
                        WindowStatus window2 = new WindowStatus();
                        window2.Show();
                        break;
                    case "По срочности":
                        WindowUrgently windowUrgently = new WindowUrgently();
                        windowUrgently.Show(); 
                        break;
                    default:
                        MessageBox.Show("Неизвестное значение");
                        break;
                }
            }
        }
    }
}

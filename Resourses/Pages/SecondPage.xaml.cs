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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2.Resourses.Pages
{
    /// <summary>
    /// Логика взаимодействия для SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        public SecondPage()
        {
            InitializeComponent();
            

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Ivent ivents = new Ivent
            {

                Name = TxtNameIvent.Text,
                Date = DateTime.Parse(TxtDate.Text)

            };
            PR1_chessEntities.GetContext().Ivent.Add(ivents);
            PR1_chessEntities.GetContext().SaveChanges();

            MessageBoxResult boxResult = MessageBox.Show("Данные добавлены. Добавить еще?",
                "Сообщение", MessageBoxButton.YesNo);
            if (boxResult == MessageBoxResult.Yes)
            {
                TxtNameIvent.Clear();
                TxtDate.Clear();
                TxtDate.Focus();
            }
            else
                NavigationService.Navigate(new StartPage());
        }
    }
}

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

namespace AdAgency
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Visibility = Visibility.Hidden;
            AuthorisationWindow authorisation = new AuthorisationWindow(this);
            authorisation.Show();
            UpdateRenderedServicesList();
            UpdateServicesList();
            UpdateCustomersList();
            UpdateUsersList();
        }

        public void UpdateRenderedServicesList() => DGridRenderedServices.ItemsSource = Context.GetContext().RenderedServices.ToList();
        public void UpdateServicesList() => DGridServices.ItemsSource = Context.GetContext().Services.ToList();
        public void UpdateCustomersList() => DGridCustomers.ItemsSource = Context.GetContext().Customers.ToList();
        public void UpdateUsersList() => DGridUsers.ItemsSource = Context.GetContext().Users.ToList();

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (TabCtrl.SelectedItem == TabCustomers)
            {
                CustomerWindow wind = new CustomerWindow(this, DGridCustomers.SelectedItem as Customer);
                wind.Show();
            }
            if (TabCtrl.SelectedItem == TabRenderedServices)
            {
                RenderedServiceWindow wind = new RenderedServiceWindow(this, DGridRenderedServices.SelectedItem as RenderedService);
                wind.Show();
            }
            if (TabCtrl.SelectedItem == TabUsers)
            {
                UserWindow wind = new UserWindow(this, DGridUsers.SelectedItem as User);
                wind.Show();
            }
            if (TabCtrl.SelectedItem == TabServices)
            {
                ServiceWindow wind = new ServiceWindow(this, DGridServices.SelectedItem as Service);
                wind.Show();
            }
        }

        private void Btn_Create_Click(object sender, RoutedEventArgs e)
        {
            if (TabCtrl.SelectedItem == TabCustomers)
            {
                CustomerWindow wind = new CustomerWindow(this);
                wind.Show();
            }
            if (TabCtrl.SelectedItem == TabRenderedServices)
            {
                RenderedServiceWindow wind = new RenderedServiceWindow(this);
                wind.Show();
            }
            if (TabCtrl.SelectedItem == TabUsers)
            {
                UserWindow wind = new UserWindow(this);
                wind.Show();
            }
            if (TabCtrl.SelectedItem == TabServices)
            {
                ServiceWindow wind = new ServiceWindow(this);
                wind.Show();
            }
        }
    }
}

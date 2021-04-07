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

namespace Interfaces
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
   

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        CustomerOperations CMO = new CustomerOperations();
        Customer customer = new Customer();


        private void button_Add_Click(object sender, RoutedEventArgs e)
        {
            
            customer.Name = textBox_Name.Text;
            customer.Surname = textBox_Surname.Text;
            CMO.Add(customer);

            listBox.ItemsSource = CMO.GetAll();
        }

        private void button_Delete_Click(object sender, RoutedEventArgs e)
        {
            CMO.Delete(listBox.SelectedValue.ToString());
            listBox.ItemsSource = CMO.GetAll();
        }

        
    }


}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
   public class CustomerOperations : ICustomer
    {
        ObservableCollection<Customer> CustomerList = new ObservableCollection<Customer>();

        public void Add(Customer customer)
        {
            CustomerList.Add(customer);
        }

        public void Delete(string Name)
        {
            var result = CustomerList.Where((p => p.Name == Name)).SingleOrDefault();
            CustomerList.Remove(result);
        }

        public ObservableCollection<Customer> GetAll()
        {
            return CustomerList;
        }
    }
}

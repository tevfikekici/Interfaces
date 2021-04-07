using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomer
    {
        void Add(Customer customer);
        void Delete(string Name);
        ObservableCollection<Customer> GetAll(); 
    }
}

using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
       public List<Customer> GetAll();
       public void Add(Customer customer);
        public List<CustomerDetailDto> GetCustomersDetails();
    }
}

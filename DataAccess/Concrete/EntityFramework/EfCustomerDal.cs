using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CustomersDbContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {


            using (CustomersDbContext context = new CustomersDbContext())
            {
                var result = from c in context.Customers
                             join co in context.Countries on c.CountryId equals co.Id

                             select new CustomerDetailDto
                             {
                                 Id = c.Id,
                                 Email = c.Email,
                                 Country = co.Name,
                                 FatherName = c.FatherName,
                                 MotherName = c.MotherName,
                                 Name = c.Name,
                                 Phone = c.Phone,
                                 Surname = c.Surname,
                                 Image = c.Image
                             };
                return result.ToList();

            }
        }
    }

}
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager countryManager = new CustomerManager(new EfCustomerDal());
            foreach (var item in countryManager.GetCustomersDetails())
            {
                Console.WriteLine(item.Id + " "+item.Name);
               
            }
            Console.ReadLine();
        }
    }
}

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Customer:IEntity
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Surname { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public byte[] Image { get; set; }
    }
}

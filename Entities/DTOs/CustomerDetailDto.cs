using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
   public class CustomerDetailDto:IDto
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Surname { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public byte[] Image { get; set; }
    }
}

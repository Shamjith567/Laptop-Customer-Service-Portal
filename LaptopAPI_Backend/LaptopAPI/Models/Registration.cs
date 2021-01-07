using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopAPI.Models
{
    public class Registration
    {  [Key]
        public int RegistrationId { get; set; }
        
        [Column(TypeName ="nVarchar(100)")]
        public string FirstName { get; set; }
        
        [Column(TypeName = "nVarchar(100)")]
        public string LastName { get; set; }
        
        [Column(TypeName = "nVarchar(10)")]
        public string Phone { get; set; }
        
        [Column(TypeName = "nVarchar(100)")]
        public string Email { get; set; }
        
        [Column(TypeName = "nVarchar(100)")]
        public string Password { get; set; }
    }
}

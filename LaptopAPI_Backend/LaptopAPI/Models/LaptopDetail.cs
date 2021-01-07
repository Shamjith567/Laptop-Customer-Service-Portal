using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopAPI.Models
{
    public class LaptopDetail
    {
        [Key]
        public int LaptopDetailId { get; set; }
        
        [Column(TypeName ="nvarchar(100)")]
        public string Summary { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(10)")] // dd/mm/yyyy
        public string Date { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string ComplaintType { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public int UserId { get; set; }  //act as forign key
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopAPI.Models
{
    public class LaptopDetailContext: DbContext
    {
        public LaptopDetailContext(DbContextOptions<LaptopDetailContext>options):base(options)
        {

        }
        public DbSet<LaptopDetail> laptopDetails { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_VishalChavda.Models;
using Microsoft.EntityFrameworkCore;


namespace EF_VishalChavda.Data
{
    public class EFCont : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<SaleItem> SaleItems { get; set; }

        public EFCont(DbContextOptions<EFCont> options)
           : base(options)
        {
        }
    }
}

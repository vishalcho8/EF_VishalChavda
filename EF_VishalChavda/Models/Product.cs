using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_VishalChavda.Models
{
    public class Product
    {
        [Key] //Primary Key
        public string Name { get; set; }

        [StringLength(100, MinimumLength = 3)]
        public string Description { get; set; }

        [Required, Range(1, 100), DataType(DataType.Currency), Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}

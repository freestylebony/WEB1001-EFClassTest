using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFClassTest.Models
{
    public class SaleItem
    {   
        [Key]
        public int SaleItemId { get; set; }

        [Required]
        public string SaleName { get; set; }

        [Required]
        public decimal Price { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { set; get; }


        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}

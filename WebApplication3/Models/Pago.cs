using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Pago
    {
        [Key]
        public int CodPago { get; set; }
        public int CodPlato { get; set; }
    }
}

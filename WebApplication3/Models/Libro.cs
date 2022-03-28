using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace WebApplication3.Models
{
    public class Libro
    {

        [Key]
        public int idLibro { get; set; }

     
        public int cantidadPago { get; set; }
        public int Egresos { get; set; }
        public int Ingresos { get; set; }
        [DataType(DataType.Date)]
        public DateTime fechaVenta { get; set; }
    }
}

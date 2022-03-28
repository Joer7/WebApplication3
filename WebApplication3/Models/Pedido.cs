using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Pedido
    {
        [Key]
        public int NumPedido { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(50, ErrorMessage = "The name should contain more than {0} characters", MinimumLength = 3)]
        public string Apellido { get; set; }
        public int codPlato { get; set; }
        public int codCliente { get; set; }
        public int cantidad { get; set; }

        [DataType(DataType.Date)]
        public DateTime fecha { get; set; }
        public string Nit { get; set; }
    }
}

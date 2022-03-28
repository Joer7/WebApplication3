using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(50, ErrorMessage = "The name should contain more than {0} characters", MinimumLength = 3)]
        [Display(Name ="Nombre Cliente")]
        public string FirstName { get; set; }

    }
}

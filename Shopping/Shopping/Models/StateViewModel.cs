using System.ComponentModel.DataAnnotations;

namespace Shopping.Models
{
    public class StateViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Departamento ")]
        [MaxLength(50, ErrorMessage = "EL campo debe tener maximo {1} caracteres")]
        [Required(ErrorMessage = "El Campo {0} es obligatorio")]
        public string Name { get; set; }

        public int CountryId { get; set; }


    }
}

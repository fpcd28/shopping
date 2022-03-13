using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name ="Pais")]
        [MaxLength(50,ErrorMessage = "EL campo debe tener maximo {1} caracteres")]
        [Required(ErrorMessage ="El Campo {0} es obligatorio")]
        public string Name { get; set; }
    }
}

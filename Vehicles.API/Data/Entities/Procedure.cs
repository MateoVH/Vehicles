using System.ComponentModel.DataAnnotations;

namespace Vehicles.API.Data.Entities
{
    public class Procedure
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres")]
        [Display(Name = "Procedimiento")]
        public string Description { get; set; } = null!;

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DisplayFormat(DataFormatString ="{0:C2}")]
        public decimal Price { get; set; }

    }
}

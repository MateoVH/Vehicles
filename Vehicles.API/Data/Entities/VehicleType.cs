using System.ComponentModel.DataAnnotations;

namespace Vehicles.API.Data.Entities
{
    public class VehicleType
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage ="El campo {0} no puede tener más de {1} carácteres")]
        [Display(Name ="Tipo de vehiculo")]
        public string? Description { get; set; }
    }
}

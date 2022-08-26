using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Vehicles.API.Data.Entities
{
    public class Brand
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres")]
        [Display(Name = "Marca")]
        public string Description { get; set; } = null!;
    }
}

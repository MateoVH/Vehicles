using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Vehicles.API.Data.Entities
{
    public class DocumentType
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener más de {1} carácteres")]
        [Display(Name = "Tipo de documento")]
        public string Description { get; set; } = null!;
    }
}

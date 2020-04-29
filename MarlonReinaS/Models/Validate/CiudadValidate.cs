

namespace MarlonReinaS.Models
{
    
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(Ciudad))]
    public partial class Ciudad
    {
        private sealed class Ciudads
        {
            [Required]
            [MaxLength(50)]
            public string descripcion;

            [Required]
            public int codigo;
        }
    }
}
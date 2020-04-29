

namespace MarlonReinaS.Models.Validate
{
   
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(Vendedor))]
    public partial class VendedorValidate
    {
        private sealed class Vendedors
        {
            [Required]
            public int codigo;
            [Required]
            [MaxLength(50)]
            public string nombre;
            [Required]
            [MaxLength(11)]
            public int numero_identificacion;
            [Required]
            public int codigo_ciudad;
        }
    }
}
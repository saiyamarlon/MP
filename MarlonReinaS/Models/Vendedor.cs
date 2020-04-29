

namespace MarlonReinaS.Models
{   
    public partial class Vendedor
    {
        public int id { get; set; }
       
        public int codigo { get; set; }
       
        public string nombre { get; set; }
       
        public string apellido { get; set; }
       
        public int numero_identificacion { get; set; }        
        public int codigo_ciudad { get; set; }
        public virtual Ciudad Ciudad { get; set; }

    }
}
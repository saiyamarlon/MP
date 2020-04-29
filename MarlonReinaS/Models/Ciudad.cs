

namespace MarlonReinaS.Models
{
    using System.Collections.Generic;
    public partial class Ciudad
    {
        
        public Ciudad()
        {
            Vendedor = new HashSet<Vendedor>();
        }
        public int id { get; set; }

        
        public int codigo { get; set; }

        
        public string descripcion { get; set; }
       
        public virtual ICollection<Vendedor> Vendedor { get; set; }

    }
}
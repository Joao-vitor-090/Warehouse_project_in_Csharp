using System.Collections.Generic;

namespace Armazen.Models
{
    public class VendedorFormViewModel
    {
        public Vendedor Vendedor { get; set; }
        public ICollection<Deposito> Depositos { get; set; }
    }
}

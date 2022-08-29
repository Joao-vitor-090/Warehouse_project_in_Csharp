
using System.Collections.Generic;

namespace Armazen.Models
{
    public class Deposito //Departamento
    {
        public int Id { get; set; }
        public string Name { get;set;}
        public ICollection<Vendedor> vendedores { get; set; } = new List<Vendedor>();

        public Deposito()
        {

        }
        public Deposito(int id, string name)
        {
            
            Id = id;
            Name = name;

        }
    }
}

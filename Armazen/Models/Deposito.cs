using System;
using System.Collections.Generic;
using System.Linq;

namespace Armazen.Models
{
    public class Deposito //Departamento
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Deposito()
        {

        }
        public Deposito(int id, string name)
        {

            Id = id;
            Name = name;

        }
        public void AddVendedor(Vendedor seller)
        {

            Vendedores.Add(seller);//Seller = vendedor;
        }

     

    }
}

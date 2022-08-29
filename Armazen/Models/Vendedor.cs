using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Armazen.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Aniversario { get; set; }
        public double SalarioBase { get; set; }
        public ICollection<RegistroDeVenda>Registros{get;set;} = new List<RegistroDeVenda>();

        public Vendedor()
        {
            
        }
        public Vendedor(int id, string name, string email, DateTime aniversario, double salariobase)
        {
            
            Id = id;
            Name = name;
            Email = email;
            Aniversario = aniversario;
            SalarioBase = salariobase;

        }
    }
}

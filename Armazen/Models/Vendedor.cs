using System;
using System.Collections.Generic;
using System.Linq;

namespace Armazen.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Aniversario { get; set; }
        public double SalarioBase { get; set; }
        public ICollection<RegistroDeVenda> Registros { get; set; } = new List<RegistroDeVenda>();

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
        public void AddVenda(RegistroDeVenda Rs) // Adicionar Venda
        {
            Registros.Add(Rs);

        }
        public void RemoveVenda(RegistroDeVenda Rs) //Remover venda
        {
            Registros.Remove(Rs);
        }
        public double TotalVenda(DateTime Inicio, DateTime Final)
        
        { //Expressão lambda
            return Registros.Where(Rv => Rv.Data >= Inicio && Rv.Data <= Final).Sum(Rv => Rv.Quantia);
        }//Rv parametro dentro de Registro de vendas

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Armazen.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Aniversário do Funcionário")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Aniversario { get; set; }

        [Display(Name = "Salário Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double SalarioBase { get; set; }

        public ICollection<RegistroDeVenda> Registros { get; set; } = new List<RegistroDeVenda>();
        public Deposito Deposito { get; set; }

        [Display(Name = "Setor")]
        public int DepositoId { get; set; }

        public Vendedor()
        {
            
        }
        public Vendedor(int id, string name, string email, DateTime aniversario, double salariobase, Deposito deposito)
        {
            
            Id = id;
            Name = name;
            Email = email;
            Aniversario = aniversario;
            SalarioBase = salariobase;
            Deposito = deposito;

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

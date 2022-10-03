using Armazen.Data;
using Armazen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Armazen.Servicos
{
    public class VendeddorServicos
    { //Readonly previne que a dependência não seja alterada!
        private readonly ArmazenContext _Context;

        public VendeddorServicos(ArmazenContext context)
        {
            _Context = context;
        }
        public List<Vendedor> ReqTodos()
        { //chamar todos
            return _Context.Vendedor.ToList();// 
        }
        public void Enviar(Vendedor obj) //adicionar um novo vendedor ao banco de dados
        {
           // obj.Deposito = _Context.Deposito.First();
            _Context.Add(obj);
            _Context.SaveChanges();
        }
        public Vendedor ReqParaId(int id)
        {
            return _Context.Vendedor.FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _Context.Vendedor.Find(id);
            _Context.Vendedor.Remove(obj);
            _Context.SaveChanges();
        }
    }
}

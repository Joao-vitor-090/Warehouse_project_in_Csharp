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
            _Context.Add(obj);
            _Context.SaveChanges();
        }
    }
}

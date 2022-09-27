using Armazen.Data;
using Armazen.Models;
using System.Collections.Generic;
using System.Linq;

namespace Armazen.Servicos
{
    public class DepositoServicos
    {
        private readonly ArmazenContext _Context;

        public DepositoServicos(ArmazenContext context)
        {
            _Context = context;
        }
        public List<Deposito> FindAll()
        {
            return _Context.Deposito.OrderBy(x => x.Name).ToList();
        }
    }
    
}

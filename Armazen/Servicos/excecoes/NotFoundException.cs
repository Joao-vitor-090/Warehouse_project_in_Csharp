using System;

namespace Armazen.Servicos.excecoes
{
    public class NotFoundException: ApplicationException //exceção personalizada
    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}

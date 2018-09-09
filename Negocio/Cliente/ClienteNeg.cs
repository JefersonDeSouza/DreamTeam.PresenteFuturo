using Dominio.Contratos;
using Negocio.Interface;
using Repositorio.Cliente;

namespace Negocio.Cliente
{
    public class ClienteNeg : IClienteNeg
    {
        private readonly IClienteRep _clienteRep;

        public ClienteNeg()
        {
            _clienteRep = new ClienteRep();
        }

        public long Salvar(Dominio.Cliente.Cliente cliente)
        {
            return _clienteRep.Salvar(cliente);
        }
    }
}

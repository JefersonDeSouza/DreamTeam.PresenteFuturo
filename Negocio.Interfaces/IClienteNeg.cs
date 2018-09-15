using Dominio.Cliente;
using Dominio.Results;

namespace Negocio.Interface
{
    public interface IClienteNeg
    {
        long Salvar(Cliente cliente);
        void Salvar(object v);
        Step3Result Consultar(object v);
    }
}

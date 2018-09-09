namespace Dominio.Contratos
{
    public interface IClienteRep
    {
        /// <summary>
        /// Assinatura do método que irá inserir um cliente
        /// </summary>
        /// <param name="cliente">Cliente</param>
        /// <returns>clienteId</returns>
        long Salvar(Cliente.Cliente cliente);
    }
}

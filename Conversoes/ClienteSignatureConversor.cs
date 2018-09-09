using Dominio.Cliente;
using Site.Signatures;

namespace Conversoes
{
    public static class ClienteSignatureConversor
    {
        public static Cliente ToDomain(ClienteSignature signature)
        {
            if (signature == null) return null;

            return new Cliente
            {
                ClienteId = signature.ClienteId,
                Nome = signature.Nome
            };
        }
    }
}

using Dominio.Cliente;
using Site.Signatures;

namespace Conversoes
{
    public static class ClienteSignatureConversor
    {
        public static Cliente ToDomain(this ClienteSignature signature)
        {
            if (signature == null) return null;

            return new Cliente
            {
                ClienteId = signature.ClienteId,
                NomePai = signature.NomePai,
                Celular = signature.Celular,
                CPF = signature.CPF,
                Email = signature.Email,
                Evento = signature.Evento,
                Matricula = signature.Matricula,
                Telefone = signature.Telefone
            };
        }
    }
}

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
                NomeResponsavel = signature.NomeResponsavel,
                Celular = signature.Celular,
                CPF = signature.CPF.Replace(".", string.Empty).Replace("-", string.Empty),
                Email = signature.Email,
                Evento = signature.Evento,
                Matricula = signature.Matricula,
                Telefone = signature.Telefone
            };
        }
    }
}

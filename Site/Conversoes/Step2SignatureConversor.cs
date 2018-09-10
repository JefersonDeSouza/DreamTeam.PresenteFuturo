using Site.Signatures;

namespace Site.Conversoes
{
    public static class Step2SignatureConversor
    {
        public static object ToDomain(this Step2Signature signature)
        {
            if (signature == null) return null;

            return new
            {
                NomeCrianca = signature.NomeCrianca,
                NomeConvidado = signature.NomeConvidado,
                Email = signature.Email,
                Celular = signature.Celular,
                FormaPagamento = signature.FormaPagamento,
                Valor = signature.Valor,
                Messagem = signature.Messagem
            };
        }
    }
}
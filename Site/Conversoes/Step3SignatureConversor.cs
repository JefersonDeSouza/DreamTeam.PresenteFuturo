using Site.Signatures;

namespace Site.Conversoes
{
    public static class Step3SignatureConversor
    {
        public static object ToDomain(Step3Signature signature)
        {
            if (signature == null) return null;

            return new
            {
                NumeroMatricula = signature.NumeroMatricula,
                CPF = signature.CPF
            };
        }
    }
}
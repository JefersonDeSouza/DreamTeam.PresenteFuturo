using System.ComponentModel.DataAnnotations;

namespace Site.Signatures
{
    public class ClienteSignature
    {
        public long ClienteId { get; set; }

        [Required(ErrorMessage = "O nome do pai é obrigatório", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string NomePai { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [StringLength(14)]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O evento é obrigatório", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string Evento { get; set; }

        [Required(ErrorMessage = "A matricula é obrigatório", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "O número do telefone é obrigatório", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [StringLength(10)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O número do celuar é obrigatório", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [StringLength(11)]
        public string Celular { get; set; }
    }
}
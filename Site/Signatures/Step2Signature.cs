using Biblioteca.Enums;
using System.ComponentModel.DataAnnotations;

namespace Site.Signatures
{
    public class Step2Signature
    {
        [Required(ErrorMessage = "O nome da criança é obrigatório", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string NomeCrianca { get; set; }

        [Required(ErrorMessage = "O nome do convidado é obrigatório", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string NomeConvidado { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "O número do celuar é obrigatório", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [StringLength(11)]
        public string Celular { get; set; }

        [Required(ErrorMessage = "A forma de pagamento obrigatório", AllowEmptyStrings = false)]
        public FormaPagamentoEnum FormaPagamento { get; set; }

        [Required(ErrorMessage = "O valor é obrigatório", AllowEmptyStrings = false)]
        [DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]

        public decimal Valor { get; set; }

        public string Messagem { get; set; }
    }
}
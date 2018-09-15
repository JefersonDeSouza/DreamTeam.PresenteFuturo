using System.ComponentModel.DataAnnotations;

namespace Site.Signatures
{
    public class Step3Signature
    {
        [Required(ErrorMessage = "Número da matrícula é obrigatório")]
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string NumeroMatricula { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório", AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        [StringLength(14)]
        public string CPF { get; set; }
    }
}
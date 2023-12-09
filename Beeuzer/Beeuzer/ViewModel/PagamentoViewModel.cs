using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace Beeuzer.ViewModel
{
    public class PagamentoViewModel
    {
        [Display(Name = "Nome do titular")]
        [MaxLength(200, ErrorMessage = "O nome deve conter no máximo 200 caracteres")]
        public string NomeCli { get; set; }

        [Display(Name = "Data de validade")]
        [Required(ErrorMessage = "Informe a data de validade")]
        public string DataVali { get; set; }

        [Required(ErrorMessage = "Informe o número do CVV")]
        [DataType(DataType.Password)]
        [Range(0, int.MaxValue, ErrorMessage = "Digite apenas números")]
        [MaxLength(3, ErrorMessage = "O CVV deve possuir apenas 3 digitos")]
        public string CVV { get; set; }

        [Display(Name = "Número do cartão")]
        [DataType(DataType.CreditCard)]
        [Range(0, int.MaxValue, ErrorMessage = "Digite apenas números")]
        [Required(ErrorMessage = "Informe o número do cartão")]
        [MinLength(13, ErrorMessage = "O CVV deve possuir 13 digitos")]
        [MaxLength(16, ErrorMessage = "O CVV deve possuir 16 digitos")]
        public string NumCartao { get; set; }

        [Display(Name = "Tipo do cartão")]
        [Required(ErrorMessage = "Informe o número do cartão")]
        public string TipoCartao { get; set; }

        [Required(ErrorMessage = "Informe sua senha")]
        [MinLength(6, ErrorMessage = "A senha deve conter no mínimo 6 caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Beeuzer.ViewModel
{
    public class EnderecoViewModel
    {
        [Display(Name = "CEP")]
        [Required(ErrorMessage = "Informe seu CEP")]
        [Range(0, int.MaxValue, ErrorMessage = "Digite apenas números")]
        [MaxLength(8, ErrorMessage = "O CEP deve conter 8 dígitos")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Informe seu logradouro")]
        [MaxLength(200, ErrorMessage = "O logradouro deve conter no máximo 200 caracteres")]
        public string Logradouro { get; set; }

        [Display(Name = "Número do endereço")]
        [Required(ErrorMessage = "Informe o número do endereço")]
        [Range(0, int.MaxValue, ErrorMessage = "Digite apenas números")]
        [MaxLength(50, ErrorMessage = "O número do endereço deve conter no máximo 50 dígitos")]
        public string NumEndereco { get; set; }

        [Display(Name = "Complemento")]
        [Required(ErrorMessage = "Informe o complemento")]
        [MaxLength(50, ErrorMessage = "O complemento deve conter no máximo 50 caracteres")]
        public string CompEndereco { get; set; }

        [Display(Name = "Nome da cidade")]
        [Required(ErrorMessage = "Informe a cidade")]
        [MaxLength(200, ErrorMessage = "O nome da cidade deve conter no máximo 200 caracteres")]
        public string NomeCidade { get; set; }

        [Display(Name = "Nome do bairro")]
        [Required(ErrorMessage = "Informe o bairro")]
        [MaxLength(200, ErrorMessage = "O nome do bairro deve conter no máximo 200 caracteres")]
        public string NomeBairro { get; set; }
    }
}
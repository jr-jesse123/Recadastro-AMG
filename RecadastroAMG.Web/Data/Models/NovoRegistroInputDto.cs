using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecadastroAMG.Web.Data.Models
{  
  
    internal class CpfValidatorAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var cpf =  Domain.CPFModule.Create((string)value);
            return cpf.IsOk;
        }
    }
    
    public class NovoRegistroInputDto
    {
        [Required, MinLength(8)]
        public string CEP { get; set; }
        [Required]
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Cidade { get; set; }
        
        [Required, MinLength(5), RegularExpression(@".+\s.+")]
        public string Nome { get; set; }
        [CpfValidator]
        public string CPF { get; set; }
        public int CRM { get; set; }
        [Range(minimum: 1900, maximum: 2021)]
        public int AnoFormatura { get; set; }
        [Required]
        public Enums.Especialidade? Especialidade { get; set; }
        [Range(typeof(DateTime), "01/01/1900", "01/01/2010")]
        public DateTime DataNascimento { get; set; }
        public Domain.Sexo? Sexo { get; set; }
        [Required]
        public Enums.Estado Estado { get; set; }
        [Phone(ErrorMessage = "Telefone 1 Incorreto")]
        public string Telefone1 { get; set; }
        [Phone(ErrorMessage = "Telefone 2 Incorreto")]
        public string Telefone2 { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }


 
}

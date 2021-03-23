using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecadastroAMG.Web.Data.Models
{
   
    public class EnderecoDto
    {
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public Enums.Estado Estado { get; set; }
    }


    public class ContatoDto
    {
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
    }

    public class PersonalInfoDto
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int CRM { get; set; }
        public int AnoFormatura { get; set; }
        public Enums.Especialidade Especialidade { get; set; }
        public DateTime DataNascimento { get; set; } = new DateTime(2000, 01, 01);
        public Domain.Sexo? Sexo { get; set; }

    }



    public class NovoRegistroInputDto
    {
        public PersonalInfoDto personalInfo { get; set; } = new();
        public ContatoDto Contato { get; set; } = new();
        public EnderecoDto Endereco { get; set; } = new();
    }
}

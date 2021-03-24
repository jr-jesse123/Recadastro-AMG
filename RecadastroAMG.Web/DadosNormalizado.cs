using System;
using System.Collections.Generic;

#nullable disable

namespace RecadastroAMG.Web
{
    public partial class DadosNormalizado
    {

        public DadosNormalizado()
        {
            AtualizadoEm = DateTime.Now;
        }
        public DateTime AtualizadoEm { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Crm { get; set; }
        public int AnoFormatura { get; set; }
        public int Especialidade { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public int? Sexo { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Cep { get; set; }
        public string Logradoutro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Estado { get; set; }
    }
}

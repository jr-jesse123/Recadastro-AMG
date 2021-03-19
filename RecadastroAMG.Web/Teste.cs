using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecadastroAMG.Web
{
    public class Teste
    {
        private readonly Func<int> teste;

        public Teste(Func<int> teste)
        {
            this.teste = teste;
        }


        public int testando()
        {
            return teste.Invoke();
        }
    }
}

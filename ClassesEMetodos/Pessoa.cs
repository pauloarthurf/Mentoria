using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentotia.ClassesEMetodos
{
    internal class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade} anos.");
        }
        public void imprimir()
        {
            Console.WriteLine(Apresentar());
        }
        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentotia.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Paulo";
            sicrano.Idade = 21;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");
            sicrano.imprimir();
            var fulano = new Pessoa();
            fulano.Nome = "Arthur";
            fulano.Idade = 22;
            fulano .imprimir(); 
             
            var fulano1 = fulano.Apresentar();
        }
    }
}

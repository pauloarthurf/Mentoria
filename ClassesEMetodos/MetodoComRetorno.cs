using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentotia.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
    class CalculadoraCadeia {
        int memoria;
        public CalculadoraCadeia Somar (int a)
        {
            memoria += a;
            return this; 
        }
        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }
        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }
    }
    class MetodoComRetorno
    {
        public static void Executar()
        {
            var calculadoreComum = new CalculadoraComum();

            Console.WriteLine(calculadoreComum.Somar(1, 2));
            Console.WriteLine(calculadoreComum.Subtrair(1, 2));
            Console.WriteLine(calculadoreComum.Multiplicar(1, 2));
        }
    }
}

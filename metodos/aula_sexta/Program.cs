using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_sexta
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("bem vindo pessaol");
                Frase();
            Console.WriteLine("aqui nova forma" + Soma(100, 10));
            Console.WriteLine("aqui é mulpliação:"+Multiplica(100,10));
            Console.WriteLine("aqui nova forma" + Divisao(100, 10));
            Console.WriteLine("aqui nova forma" + Subtração(100, 10));



        }
        static void Frase()
        {
            Console.WriteLine("olá pessaol"+"aula sobre metodo ");

        } 
        static double Soma(int n1,int n2)
        {
            double resultado;
            resultado = n1 + n2;
            return resultado;
        }
        static double Multiplica(int n1,int n2)
        {
            double resultado;
            resultado = n1 * n2;
            return resultado;

        }
        static double Divisao(int n1 ,int n2)
        {
            double resultado;
            resultado=n1 / n2;
            return resultado;

        }
        static double Subtração(int n1,int n2)
        {
            double resultado;
            resultado=n1-n2;
            return resultado;
        }
    }

}

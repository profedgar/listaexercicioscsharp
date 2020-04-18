using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

           String nome="Edgar";
           double salariofixo=0,totalvendas=0,percentualvendas=0,salariofinal=0;

            salariofixo=3000.50;
            totalvendas=2543.35;
            percentualvendas=(totalvendas/100)*15;
            salariofinal=salariofixo+percentualvendas;

            Console.WriteLine("Nome do Funcionario: " + nome);
            Console.WriteLine("Salario Fixo: " + salariofixo);
            Console.WriteLine("Salario Final: " + salariofinal);

            Console.ReadLine();









            Console.WriteLine("Hello World!");
        }
    }
}

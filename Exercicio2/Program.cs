using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

int num1,num2,soma,multiplicacao,subtracao;
float divisao;

num1=11;
num2=5;
soma=num1+num2;
multiplicacao=num1*num2;
subtracao=num1-num2;

divisao=(float)num1/(float)num2;

Console.WriteLine("A soma é " + soma);
Console.WriteLine("A multiplicacao é " + multiplicacao);
Console.WriteLine("A divisao é " + divisao);
Console.WriteLine("A subtracao é " + subtracao);
Console.ReadLine();


          
        }
    }
}

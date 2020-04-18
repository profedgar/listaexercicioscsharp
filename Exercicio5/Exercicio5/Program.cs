using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            String nome="";
            int nota1,nota2,nota3;
            double media;

            Console.WriteLine("Digite  o nome do aluno");
            nome=Console.ReadLine();

             Console.WriteLine("Digite a nota da primeira prova");
            nota1=int.Parse(Console.ReadLine());

              Console.WriteLine("Digite a nota da segunda prova");
            nota2=int.Parse(Console.ReadLine());

              Console.WriteLine("Digite a nota da terceira prova");
            nota3=int.Parse(Console.ReadLine());

            media=(nota1+nota2+nota3)/3;

            Console.WriteLine("Nome do aluno:" + nome);
            Console.WriteLine("Media: " + media);

            Console.ReadLine();
        }
    }
}

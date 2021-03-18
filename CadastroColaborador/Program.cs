using System;
using System.Globalization;

namespace CadastroColaborador
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosPessoais p1 = new DadosPessoais();
            
            Console.WriteLine("***CADASTRO DE COLABORADORES***");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Endereço: ");
            p1.end = Console.ReadLine();
            Console.Write("Telefone: ");
            p1.tel = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());
            Console.Write("Salário: ");
            p1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**********************************************");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("DADOS CADASTRADOS COM SUCESSO!");
            Console.WriteLine();
            Console.WriteLine("Nome:" + p1.nome);
            Console.WriteLine("Endereço: " + p1.end);
            Console.WriteLine("Telefefone: " + p1.tel);
            Console.WriteLine("Idade: " + p1.idade + " anos");
            Console.WriteLine("Salário: "  + p1.salario);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*************************************************");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

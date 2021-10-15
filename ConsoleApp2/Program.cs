using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Digite o nome:");
            pessoa.nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            pessoa.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu RG: ");
            pessoa.rg = Console.ReadLine();

            Console.WriteLine("Digite seu cpf: ");
            pessoa.cpf = Console.ReadLine();


            Console.WriteLine("Nome: {0}", pessoa.nome);
            Console.WriteLine("Idade: {0}", pessoa.idade);
            Console.WriteLine("rg: {0}", pessoa.rg);
            Console.WriteLine("cpf: {0}", pessoa.cpf);

            Pessoa pessoasilvia = new Pessoa();

            pessoasilvia.nome = "Silvia Mendes";
            pessoasilvia.idade = 32;
            pessoasilvia.rg = "147.147.147.65";
            pessoasilvia.cpf = "131.131.131.13";

            Console.WriteLine("Nome: {0}", pessoasilvia.nome);
            Console.WriteLine("Idade: {0}", pessoasilvia.idade);
            Console.WriteLine("rg: {0}", pessoasilvia.rg);
            Console.WriteLine("cpf: {0}", pessoasilvia.cpf);

            pessoa.Acenar(pessoasilvia);
            pessoa.PerguntarIdade(pessoasilvia)

        }
    }
}

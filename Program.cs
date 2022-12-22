// See https://aka.ms/new-console-template for more information
using CadastroPessoas.Classes;

Console.WriteLine("Hello, World!");

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Wilson";
novaPf.cpf = "12345";

Console.WriteLine(novaPf.nome);

Console.WriteLine("Nome: " + novaPf.nome + " - Cpf: " + novaPf.cpf);

Console.WriteLine($"Nome: {novaPf.nome} - Cpf: {novaPf.cpf}");

float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);

Console.WriteLine(impostoPagar);

Console.WriteLine($"R$ {impostoPagar:0.00}");

Console.WriteLine(impostoPagar.ToString("C"));
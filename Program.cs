// See https://aka.ms/new-console-template for more information
using CadastroPessoas.Classes;

Console.WriteLine("Hello, World!");

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Wilson";
novaPf.cpf = "12345";

Console.WriteLine(novaPf.nome);

Console.WriteLine("Nome: " + novaPf.nome + " - Cpf: " + novaPf.cpf);

Console.WriteLine($"Nome: {novaPf.nome} - Cpf: {novaPf.cpf}");
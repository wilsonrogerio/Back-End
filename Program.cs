// See https://aka.ms/new-console-template for more information
using CadastroPessoas.Classes;

Console.WriteLine("Hello, World!");

PessoaFisica novaPf = new PessoaFisica();
Endereco novoEndPF = new Endereco();

novaPf.nome = "Wilson";
novaPf.cpf = "12345";
novaPf.DataNasc = new DateTime(1998, 09 , 01);



novoEndPF.logradouro = "gilberto kun";
novoEndPF.numero = 169;
novoEndPF.complemento = "esquina";
novoEndPF.endComercial = false;

novaPf.end = novoEndPF;

Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereço: {novoEndPF.logradouro} Num:{novoEndPF.numero}
Maior de idade: {novaPf.ValidarDataNasc(novaPf.DataNasc)}
"
);


// Console.WriteLine(novaPf.nome);

// Console.WriteLine("Nome: " + novaPf.nome + " - Cpf: " + novaPf.cpf);

// Console.WriteLine($"Nome: {novaPf.nome} - Cpf: {novaPf.cpf}");

// float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);

// Console.WriteLine(impostoPagar);

// Console.WriteLine($"R$ {impostoPagar:0.00}");

// Console.WriteLine(impostoPagar.ToString("C"));

//encontro remoto 4

// data formatada

DateTime temp = new DateTime(1998/09/01);

// Console.WriteLine(novaPf.ValidarDataNasc(temp));

// data nao formatada

// Console.WriteLine(novaPf.ValidarDataNasc("01-09-1998"));





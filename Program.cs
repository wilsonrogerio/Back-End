// See https://aka.ms/new-console-template for more information
using CadastroPessoas.Classes;

Console.WriteLine("Hello, World!");

// PessoaFisica novaPf = new PessoaFisica();
// Endereco novoEndPF = new Endereco();


PessoaJuridica novoPJ = new PessoaJuridica();
Endereco novoEndPJ = new Endereco();

novoPJ.nome = "Wilson";
novoPJ.cnpj = "60.876.486/0001-58";
novoPJ.rendimento = 4500.50f;

novoEndPJ.logradouro = "gilberto kun";
novoEndPJ.numero = 169;
novoEndPJ.complemento = "esquina";
novoEndPJ.endComercial = false;

novoPJ.end = novoEndPJ;

Console.WriteLine(@$"
Nome: {novoPJ.nome}
Endereço: {novoEndPJ.logradouro} Num:{novoEndPJ.numero}
CNPJ:{novoPJ.cnpj} - Valido: {novoPJ.ValidarCnpj(novoPJ.cnpj)}
"
);

// Console.WriteLine(novoPJ.ValidarCnpj("60876486000158"));

// Console.WriteLine(novoPJ.ValidarCnpj("60.876.486/0001-58"));



// novaPf.nome = "Wilson";
// novaPf.cpf = "12345";
// novaPf.DataNasc = new DateTime(1998, 09 , 01);



// novoEndPF.logradouro = "gilberto kun";
// novoEndPF.numero = 169;
// novoEndPF.complemento = "esquina";
// novoEndPF.endComercial = false;

// novaPf.end = novoEndPF;

// Console.WriteLine(@$"
// Nome: {novaPf.nome}
// Endereço: {novoEndPF.logradouro} Num:{novoEndPF.numero}
// Maior de idade: {novaPf.ValidarDataNasc(novaPf.DataNasc)}
// "
// );


// Console.WriteLine(novaPf.nome);

// Console.WriteLine("Nome: " + novaPf.nome + " - Cpf: " + novaPf.cpf);

// Console.WriteLine($"Nome: {novaPf.nome} - Cpf: {novaPf.cpf}");

// float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);

// Console.WriteLine(impostoPagar);

// Console.WriteLine($"R$ {impostoPagar:0.00}");

// Console.WriteLine(impostoPagar.ToString("C"));

//encontro remoto 4

// data formatada

// DateTime temp = new DateTime(1998/09/01);

// Console.WriteLine(novaPf.ValidarDataNasc(temp));

// data nao formatada

// Console.WriteLine(novaPf.ValidarDataNasc("01-09-1998"));



// var cnpj = "60876486000158";
// novoPJ.ValidarCnpj("60876486000158");




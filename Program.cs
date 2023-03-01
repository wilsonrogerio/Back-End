// See https://aka.ms/new-console-template for more information

using CadastroPessoas.Classes;
string? opcao;
string? opcaoPJ;

PessoaFisica novaPf = new PessoaFisica();
Endereco novoEndPF = new Endereco();


// PessoaJuridica novoPJ = new PessoaJuridica();
// Endereco novoEndPJ = new Endereco();
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

// Console.WriteLine("Hello, World!");


// Menu de console 

Console.WriteLine(@$"
=====================================================
|   Bem Vindo ao Sistema de Cadastro de Pessoas     |
|                Fisicas e Juridicas                |
=====================================================
");
Thread.Sleep(2000);

Utils.BarraCarregamento("Carregando");
Console.Clear();

do
{
    Console.Clear();
    Console.WriteLine(@$"
=====================================================
|          Escolha uma opcao a baixo                |
|          e tecle enter para continuar             |
=====================================================
|                                                   |
|            1 - Pessoa Juridica                    |
|            2 - Pessoa Fisica                      |
|            0 - sair                               |
|                                                   | 
=====================================================
");

    opcao = Console.ReadLine();
    Console.WriteLine($"Voce digitou: {opcao}");


    switch (opcao)
    {
        case "1":

            do
            {
                Console.Clear();

                Console.WriteLine(@$"
        =====================================================
        |        Digite um numero da opçao a baixo          |
        =====================================================
        |                                                   |
        |            1 - Cadastrar Pessoa Juridica          |
        |            2 - Listar Pessoa Juridica             |
        |            0 - Voltar                             |
        |                                                   | 
        =====================================================
        ");




                opcaoPJ = Console.ReadLine();

                switch (opcaoPJ)
                {
                    case "1":
                        PessoaJuridica novoPJ = new PessoaJuridica();
                        Endereco novoEndPJ = new Endereco();

                        Console.Clear();
                        Console.WriteLine("Digite o nome da razao social");
                        novoPJ.razaoSocial = Console.ReadLine();

                        Console.WriteLine("Digite seu CNPJ");
                        novoPJ.cnpj = Console.ReadLine();

                        Console.WriteLine("Digite o rendimento da empresa");
                        string? rendEntrada = Console.ReadLine();
                        //convertendo de string para float.
                        float.TryParse(rendEntrada, out float rendConvertido);
                        novoPJ.rendimento = rendConvertido;

                        //Endereço
                        Console.WriteLine("Digite o nome da rua");
                        novoEndPJ.logradouro = Console.ReadLine();

                        Console.WriteLine("Digite o Numero");
                        string? numEntrada = Console.ReadLine();
                        int.TryParse(numEntrada, out int numConvertido);
                        novoEndPJ.numero = numConvertido;

                        novoPJ.end = novoEndPJ;

                        listaPj.Add(novoPJ);

                        Console.WriteLine("Cadastrado com sucesso");
                        Console.WriteLine("Pressione qualquer tecla para sair");
                        Console.ReadLine();

                        Thread.Sleep(1000);



                        break;

                    case "2":

                        Console.Clear();

                        if (listaPj.Count > 0)
                        {
                        foreach (PessoaJuridica cadaPJ in listaPj)
                        {

                            Console.Clear();
                            Console.WriteLine(@$"
                        Razao socila: {cadaPJ.razaoSocial}
                        Endereço: {cadaPJ.end.logradouro} Num:{cadaPJ.end.numero}
                        CNPJ:{cadaPJ.cnpj} - Valido: {cadaPJ.ValidarCnpj(cadaPJ.cnpj)}
                        "
                             );

                        }

                        Console.WriteLine("Pressione qualquer tecla para sair");
                        Console.ReadLine();
                            
                        }else{
                            Console.WriteLine("Lista esta vazia");
                            Thread.Sleep(4000);
                        }
                        


                        break;

                    case "0":
                        Console.WriteLine("Voce escolheu sair");
                        Thread.Sleep(2000);


                        break;


                    default:
                        Console.WriteLine("Digite um valor correto");
                        Thread.Sleep(2000);
                        break;
                }
            } while (opcaoPJ != "0");



































            //     novaPf.nome = "Wilson";
            //     novaPf.cpf = "12345";
            //     novaPf.DataNasc = new DateTime(1998, 09, 01);



            //     novoEndPF.logradouro = "gilberto kun";
            //     novoEndPF.numero = 169;
            //     novoEndPF.complemento = "esquina";
            //     novoEndPF.endComercial = false;

            //     novaPf.end = novoEndPF;
            //     float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);

            //     Console.WriteLine(@$"
            // Nome: {novaPf.nome}
            // Endereço: {novoEndPF.logradouro} Num:{novoEndPF.numero}
            // Maior de idade: {novaPf.ValidarDataNasc(novaPf.DataNasc)}
            // "
            //     );
            //     Console.WriteLine(impostoPagar.ToString("C"));

            Thread.Sleep(2000);


            break;

        case "2":

            Console.WriteLine($"Pessoa Juridica");

        //     novoPJ.nome = "Wilson";
        //     novoPJ.cnpj = "60.876.486/0001-58";
        //     novoPJ.rendimento = 4500.50f;

        //     novoEndPJ.logradouro = "gilberto kun";
        //     novoEndPJ.numero = 169;
        //     novoEndPJ.complemento = "esquina";
        //     novoEndPJ.endComercial = false;

        //     novoPJ.end = novoEndPJ;

        //     Console.WriteLine(@$"
        // Nome: {novoPJ.nome}
        // Endereço: {novoEndPJ.logradouro} Num:{novoEndPJ.numero}
        // CNPJ:{novoPJ.cnpj} - Valido: {novoPJ.ValidarCnpj(novoPJ.cnpj)}
        // "
        //     );

            Console.WriteLine($"Pressione qualquer tecla para sair");


            Console.ReadLine();

            break;

        case "0":
            Console.WriteLine($"Sair do menu");
            Utils.BarraCarregamento("Finalizando");
            Thread.Sleep(2000);

            break;

        default:

            Console.WriteLine($"Insira um valor correto");
            Thread.Sleep(1000);

            break;
    }

} while (opcao != "0");


















// PessoaFisica novaPf = new PessoaFisica();
// Endereco novoEndPF = new Endereco();


// PessoaJuridica novoPJ = new PessoaJuridica();
// Endereco novoEndPJ = new Endereco();

// novoPJ.nome = "Wilson";
// novoPJ.cnpj = "60.876.486/0001-58";
// novoPJ.rendimento = 4500.50f;

// novoEndPJ.logradouro = "gilberto kun";
// novoEndPJ.numero = 169;
// novoEndPJ.complemento = "esquina";
// novoEndPJ.endComercial = false;

// novoPJ.end = novoEndPJ;

// Console.WriteLine(@$"
// Nome: {novoPJ.nome}
// Endereço: {novoEndPJ.logradouro} Num:{novoEndPJ.numero}
// CNPJ:{novoPJ.cnpj} - Valido: {novoPJ.ValidarCnpj(novoPJ.cnpj)}
// "
// );

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




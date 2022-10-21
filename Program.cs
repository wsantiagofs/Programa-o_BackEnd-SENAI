using Back_End_ER2.Classes;
using Programacao_BackEnd_SENAI.Classes;

// PessoaFisica novaPF = new PessoaFisica();
// Endereco novoEndPF = new Endereco();

// novaPF.nome = "William";
// novaPF.cpf = "12345678990";
// novaPF.rendimento = 6600.4f;
// novaPF.dataNasc = new DateTime(2000, 10, 01);

// novoEndPF.logradouro = "Rua Niteroi";
// novoEndPF.numero = 180;
// novoEndPF.complemento = "Esacola SENAI";
// novoEndPF.endComercial = true;

// novaPF.endereco = novoEndPF;

// Console.WriteLine(@$"
// Nome: {novaPF.nome}, 
// Rendimento: {novaPF.rendimento} 
// Cpf: {novaPF.cpf} 
// Logradouro: {novaPF.endereco.logradouro}
// Numero: {novaPF.endereco.numero}
// ");

PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.nome = "Nome Pj";
novaPj.razaoSocial = "Razão Social PJ";
novaPj.cnpj = "00.476.645/0001-03";

novoEndPj.logradouro = "Rua Niteroi";
novoEndPj.numero = 180;

novaPj.endereco = novoEndPj;

Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj} - Valido: {novaPj.ValidarCnpj(novaPj.cnpj)}
");



// Console.WriteLine(novaPF.nome);
// Console.WriteLine(novaPF.cpf);
// Console.WriteLine("Bem vindo");

// concatenação 
// Console.WriteLine("Bem vindo - " + novaPF.nome);

//interpolação
// Console.WriteLine($"Bem vindo: {novaPF.nome} de Cpf: {novaPF.cpf}");

// Pessoa Fisica =======================================================================
// float impostaPagar = novaPF.CalcularImposto (novaPF.rendimento);
// Console.WriteLine($"{impostaPagar:0.00}");
// Console.WriteLine(impostaPagar.ToString("C"));

// Pessoa Juridica =========================================================================
// PessoaJuridica novaPj = new PessoaJuridica();
// Console.WriteLine(novaPj.CalcularImposto(6600.5f));

// var date1 = new DateTime (2008, 5, 1, 8, 30, 52);
// Console.WriteLine(date1);

// DateTime temp = new DateTime (2000, 01, 01);
// Console.WriteLine(novaPF.ValidarDataNasc("01/01/2000"));
using ClienteCadastro.Controllers;

Console.WriteLine("************  SISTEMA DE CADASTRO E CONTROLE DE CLIENTES  ************");
Console.WriteLine("Aula 01 - C# WebDeveloper\n");

var clienteController = new ClienteController();
clienteController.CadastrarCliente();

Console.ReadKey();
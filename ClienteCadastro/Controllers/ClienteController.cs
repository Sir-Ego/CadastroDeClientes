using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteCadastro.Entities;
using ClienteCadastro.Repositories;
using ClienteCadastro.Services;

namespace ClienteCadastro.Controllers
{
    public class ClienteController
    {
        public void CadastrarCliente()
        {
            Console.WriteLine("\n------------------------------- CADASTRE O CLIENTE -------------------------------\n");

            var cliente = new Cliente();

            cliente.Id = Guid.NewGuid();

            Console.Write("INFORME O NOME DO CLIENTE..........: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("INFORME O EMAIL DO CLIENTE.........: ");
            cliente.Email = Console.ReadLine();

            Console.Write("INFORME O CPF DO CLIENTE...........: ");
            cliente.Cpf = Console.ReadLine();

            Console.Write("INFORME O TELEFONE DO CLIENTE......: ");
            cliente.Telefone = Console.ReadLine();

            cliente.DataCadastro = DateTime.Now;

            Console.Write("INFORME O CEP DO CLIENTE......: ");
            var cep = Console.ReadLine();

            //consultando o Cep na API para obter o endereço
            var viaCepService = new ViaCepService();

            //armazenando os dados do Endereço obtido 
            var endereco = viaCepService.ConsultarCep(cep);
            endereco.Id = Guid.NewGuid(); //gerando um id para o endereço

            Console.Write("INFORME O NUMERO DO ENDEREÇO......: ");
            endereco.Numero = Console.ReadLine();

            Console.Write("INFORME O COMPLEMENTO DO ENDEREÇO......: ");
            endereco.Complemento = Console.ReadLine();

            Console.Write("INFORME A CIDADE......: ");
            endereco.Cidade = Console.ReadLine();

            //associando o Endereço obtido ao cliente 
            cliente.Endereco = endereco;

            #region Mostrando os dados do cliente na tela (console)

            Console.WriteLine("\nDADOS DO CLIENTE: ");
            Console.WriteLine("\tId..............: " + cliente.Id);
            Console.WriteLine("\tNome............: " + cliente.Nome);
            Console.WriteLine("\tEmail...........: " + cliente.Email);
            Console.WriteLine("\tCPF.............: " + cliente.Cpf);
            Console.WriteLine("\tTelefone........: " + cliente.Telefone);
            Console.WriteLine($"\tLogradouro......: {endereco.Logradouro}");
            Console.WriteLine("\tNumero..........: " + endereco.Numero);
            Console.WriteLine($"\tComplemento.....: {endereco.Complemento}");
            Console.WriteLine("\tBairro..........: " + endereco.Bairro);
            Console.WriteLine("\tCidade..........: " + endereco.Cidade);
            Console.WriteLine("\tUF..............: " + endereco.Uf);
            Console.WriteLine("\tCep.............: " + endereco.Cep);
            Console.WriteLine("\tCadastrado em...: " + cliente.DataCadastro);
            #endregion


            //criando um objeto para a classe ClienteRepository
            var clienteRepositoryTxt = new ClienteRepositoryTxt();

            //implantação(chamamento) dos metodos da classe ClienteRepository
            clienteRepositoryTxt.Exportar(cliente, endereco);

            var clienteRepositoryJson = new ClienteRepositoryJson();
            clienteRepositoryJson.Exportar(cliente, endereco);

            var clienteRepositoryXml = new ClienteRepositoryXml();
            clienteRepositoryXml.Exportar(cliente, endereco);


            Console.WriteLine("\nCLIENTE CADASTRADO COM SUCESSO!");

        }

    }
}

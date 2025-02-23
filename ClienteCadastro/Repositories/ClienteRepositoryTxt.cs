using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteCadastro.Entities;
using ClienteCadastro.Interfaces;

namespace ClienteCadastro.Repositories
{
    public class ClienteRepositoryTxt : IClienteRepository
    {

        /// <summary>
        /// Método para exportar os dados do cliente para arquivo TXT
        /// </summary>
        public void Exportar(Cliente cliente, Endereco endereco)
        {
            var streamWriter = new StreamWriter("F:\\Dev\\ProjetoAula01\\ClienteCadastro\\cliente.txt", true);

            streamWriter.WriteLine("\n\nID: " + cliente.Id);
            streamWriter.WriteLine("NOME: " + cliente.Nome);
            streamWriter.WriteLine("EMAIL: " + cliente.Email);
            streamWriter.WriteLine("CPF: " + cliente.Cpf);
            streamWriter.WriteLine("TELEFONE: " + cliente.Telefone);
            streamWriter.WriteLine("LOGRADOURO: " + endereco.Logradouro);

            streamWriter.WriteLine("NUMERO: " + endereco.Numero);
            streamWriter.WriteLine("COMPLEMENTO: " + endereco.Complemento);
            streamWriter.WriteLine("BAIRRO: " + endereco.Bairro);
            streamWriter.WriteLine("CIDADE: " + endereco.Cidade);
            streamWriter.WriteLine("UF: " + endereco.Uf);
            streamWriter.WriteLine("CEP: " + endereco.Cep);
            streamWriter.WriteLine("DATA DE CADASTRO: " + cliente.DataCadastro);

            //encerrando o arquivo
            streamWriter.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteCadastro.Entities;
using ClienteCadastro.Interfaces;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace ClienteCadastro.Repositories
{
   public class ClienteRepositoryJson : IClienteRepository
    {
        /// <summary>
        /// Método para exportar os dados do cliente para arquivo JSON
        /// </summary>
        /// <param name="cliente"></param>
        public void Exportar(Cliente cliente, Endereco endereco)
        {
            var streamWriter = new StreamWriter("F:\\Dev\\ProjetoAula01\\ClienteCadastro\\cliente.json");

            //grava os dados do cliente no arquivo em formato JSON
            streamWriter.WriteLine(JsonConvert.SerializeObject(cliente, Formatting.Indented));

            //encerrando o arquivo
            streamWriter.Close();
        }
    }

}

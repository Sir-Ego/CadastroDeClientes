using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ClienteCadastro.Entities;
using ClienteCadastro.Interfaces;

namespace ClienteCadastro.Repositories
{
    public class ClienteRepositoryXml : IClienteRepository
    {
        /// <summary>
        /// Método para exportar os dados do cliente para arquivo XML
        /// </summary>
        public void Exportar(Cliente cliente, Endereco endereco)
        {
            //Serializar (convertendo) os dados do funcionário para formato XML
            var xml = new XmlSerializer(typeof(Cliente));

            //abrindo um arquivo para gravação
            var streamWriter = new StreamWriter($"F:\\Dev\\ProjetoAula01\\ClienteCadastro\\cliente_{cliente.Id}.xml");

            //gravar os dados do funcionário em XML dentro do arquivo
            xml.Serialize(streamWriter, cliente);

            //fechar o arquivo
            streamWriter.Close();
        }
    }

   

}

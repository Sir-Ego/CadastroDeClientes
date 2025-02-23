using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteCadastro.Entities;
using Newtonsoft.Json;

namespace ClienteCadastro.Services
{
    public class ViaCepService
    {
        /// <summary>
        /// Método para consultar os dados do endereço de um Cep
        /// </summary>
        public Endereco ConsultarCep(string Cep)
        {
            //instanciando a Classe HttpClient
            var httpClient = new HttpClient();

            //fazendo a consulta do cep na Api e capturando o retorno
            var response = httpClient.GetAsync
                ("https://viacep.com.br/ws/" + Cep + "/json").Result;

            //obtendo os dados em json retornados pela API
            var json = response.Content.ReadAsStringAsync().Result;

            //copiando os dados obtidos do Json fornecido pela API
            //para um objeto Endereco do projeto
            return JsonConvert.DeserializeObject<Endereco>(json);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteCadastro.Entities
{
    public class Endereco
    {
        #region Propriedades

        public Guid Id { get; set; }
        public string? Logradouro { get; set; }
        public string? Complemento { get; set; }
        public string? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? Uf { get; set; }
        public string? Cep { get; set; }

        #endregion

    }
}

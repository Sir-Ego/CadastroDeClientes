using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteCadastro.Entities;

namespace ClienteCadastro.Interfaces
{ /// <summary>
  /// Interface para abstração dos métodos de
  /// repositório de dados de Cliente
  /// </summary>
    public interface IClienteRepository
    {
        //método abstrato!
        void Exportar(Cliente cliente, Endereco endereco);

    }

}

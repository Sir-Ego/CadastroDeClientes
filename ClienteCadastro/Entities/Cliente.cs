﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteCadastro.Entities
{
    public class Cliente
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public Endereco? Endereco { get; set; }
        public DateTime? DataCadastro { get; set; }

    }
}

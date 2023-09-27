using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WebAtividadeEntrevista.Models
{
    public class BeneficiarioModel
    {
        public long Id { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public long IdCliente { get; set; }
    }
}
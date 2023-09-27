using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.DML
{
    public class Beneficiario
    {
        /// <summary>
        /// ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// CPF
        /// </summary>
        public string Cpf { get; set; }
        /// <summary>
        /// NOME
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// IDCLIENTE
        /// </summary>
        public long IdCliente { get; set; }

    }

}

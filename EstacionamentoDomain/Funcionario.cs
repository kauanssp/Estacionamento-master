using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EstacionamentoDomain.Base;

namespace EstacionamentoDomain
{
    public class Funcionario : BaseEntity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

        public Estadia Estadia
        {
            get => default;
            set
            {
            }
        }
    }
}
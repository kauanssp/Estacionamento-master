using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EstacionamentoDomain.Base;

namespace EstacionamentoDomain
{
    public class Cliente : BaseEntity
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Veiculo Veiculo
        {
            get => default;
            set
            {
            }
        }
    }
}
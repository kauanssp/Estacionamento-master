using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EstacionamentoDomain.Base;

namespace EstacionamentoDomain
{
    public class Veiculo : BaseEntity
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public Cliente Cliente { get; set; }

        public Estadia Estadia
        {
            get => default;
            set
            {
            }
        }
    }
}
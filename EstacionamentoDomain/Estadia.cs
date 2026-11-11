using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EstacionamentoDomain.Base;

namespace EstacionamentoDomain
{
    public class Estadia : BaseEntity
    {
        public DateTime dataHoraEntrada { get; set; }
        public DateTime dataHoraSaida { get; set; }

        public Pagamento Pagamento
        {
            get => default;
            set
            {
            }
        }
    }
}
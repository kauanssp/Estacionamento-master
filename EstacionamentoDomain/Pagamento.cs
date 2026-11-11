using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EstacionamentoDomain.Base;

namespace EstacionamentoDomain 
{
    public class Pagamento : BaseEntity
    {
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public string FormaPagamento { get; set; }
        public string Status { get; set; }
    }
}
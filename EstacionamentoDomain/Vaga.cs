using EstacionamentoDomain.Base;

namespace EstacionamentoDomain
{
    public class Vaga : BaseEntity
    {
        public int Numero { get; set; }
        public bool Status { get; set; }
        public string Tipo { get; set; }

        public Estadia Estadia
        {
            get => default;
            set
            {
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace EstacionamentoDomain.Base
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
    }
}

using System;

namespace Evento.Core.Domain
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id {get; protected set;}

    }
}
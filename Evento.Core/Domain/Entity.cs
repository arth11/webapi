using System;

namespace Evento.Core.Domain
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
<<<<<<< HEAD

=======
            
>>>>>>> a7212a91f12955969bb43a0d9e47ed94ccf50caf
        }

        public Guid Id {get; protected set;}

    }
}
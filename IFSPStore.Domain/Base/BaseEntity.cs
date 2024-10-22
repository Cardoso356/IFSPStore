using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.domain.Base
{
    public abstract class BaseEntity<TID> //classe visível que não é instanciável (não usamos o new para criar a classe) ela é só pra ser herdada nas outras classes. O TID a gente pode passar o tipo de que será o nosso id
    {
        protected BaseEntity()
        {

        }

        protected BaseEntity(TID id)
        {
            Id = id;
        }

        public TID? Id { get; set; } //o ? no TID é pra nãos ser nulo
        
    }
}

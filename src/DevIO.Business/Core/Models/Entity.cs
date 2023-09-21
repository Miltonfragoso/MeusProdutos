using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Core.Models
{
    public abstract class Entity
    {
        protected Entity() 
        { 
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}


/*O modificador de acesso abstract diz que só pode herdar essa class
 * 
 * O Guid define o ID da entidade antes de percistir no banco 
 * 
 * O construtor da class com o modificador de acesso Protected 
 * somente para quem herdar define um novo Id toda vez que aclass for instanciada
 */ 
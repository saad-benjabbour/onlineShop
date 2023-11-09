using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class BaseEntity
    {
        /*
           THE USES OF THIS CLASS:
           1-- to get rid of the property id in each class we have
           2-- 
         */
        public int Id { get; set; }
    }
}

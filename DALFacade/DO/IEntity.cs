using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    internal interface IEntity
    {
        int UniquId { get; set; }
        bool IsDeleted { get; set; }    
    }
}

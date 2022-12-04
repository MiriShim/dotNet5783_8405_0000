using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    internal interface IEntity
    {
        public void Print()
        {
            Console.WriteLine(this.UniquId );
        }
        int UniquId { get; set; }
        bool IsDeleted { get; set; }    
    }

    public class dd : IEntity
    {
        //void Print()
        //{
        // }
        public int UniquId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}

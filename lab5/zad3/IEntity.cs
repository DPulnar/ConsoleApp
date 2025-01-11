using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.zad3
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}

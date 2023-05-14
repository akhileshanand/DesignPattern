using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstracctFactory
{
    public interface IAnimalFactory
    {
       
            IDog GetDog();
            ITiger GetTiger();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.FoodMenu
{
    public interface IIterator 
    {
        bool HasNext();
        Object Next();
    }
}

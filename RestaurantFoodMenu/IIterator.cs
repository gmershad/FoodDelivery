using System;

namespace FoodDeliveryApp.FoodMenu
{
    public interface IIterator 
    {
        bool HasNext();
        Object Next();
    }
}

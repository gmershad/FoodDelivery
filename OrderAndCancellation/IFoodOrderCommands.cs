using FoodDeliveryApp.FoodDeliveryAppModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryApp.OrderAndCancellation
{
    public interface IFoodOrderCommands
    {
        void Execute();
    }
}

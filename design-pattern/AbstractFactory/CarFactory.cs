using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_pattern.AbstractFactory
{
    internal interface ICarFactory
    {
        ICar CreateCar();
    }
    
    internal class CarFactory
    {
    }
}

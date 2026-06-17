using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.FactoryMethods
{
    public abstract class CarFactory
    {
        public Vehicle CreateVehicle()
        {
            return CreateBuilder().Build();
        }

        protected abstract CarBuilder CreateBuilder();
    }
}

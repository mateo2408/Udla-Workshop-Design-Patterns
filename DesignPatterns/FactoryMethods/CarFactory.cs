using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.FactoryMethods
{
    public abstract class CarFactory : IVehicleFactory
    {
        public abstract string ModelKey { get; }

        public Vehicle CreateVehicle()
        {
            // Template Method: each concrete factory only defines the builder configuration.
            return CreateBuilder().Build();
        }

        protected abstract CarBuilder CreateBuilder();
    }
}

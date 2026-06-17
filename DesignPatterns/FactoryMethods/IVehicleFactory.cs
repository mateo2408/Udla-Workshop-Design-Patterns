using DesignPatterns.Models;

namespace DesignPatterns.FactoryMethods
{
    public interface IVehicleFactory
    {
        string ModelKey { get; }

        Vehicle CreateVehicle();
    }
}

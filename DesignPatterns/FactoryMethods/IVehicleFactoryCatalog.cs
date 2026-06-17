using System.Collections.Generic;
using DesignPatterns.Models;

namespace DesignPatterns.FactoryMethods
{
    public interface IVehicleFactoryCatalog
    {
        IReadOnlyCollection<VehicleFactoryOption> GetAvailableModels();

        Vehicle CreateVehicle(string modelKey);
    }
}

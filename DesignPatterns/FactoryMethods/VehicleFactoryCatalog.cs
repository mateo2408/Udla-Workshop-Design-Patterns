using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatterns.Models;

namespace DesignPatterns.FactoryMethods
{
    public class VehicleFactoryCatalog : IVehicleFactoryCatalog
    {
        private readonly IDictionary<string, IVehicleFactory> _factories;

        public VehicleFactoryCatalog(IEnumerable<IVehicleFactory> factories)
        {
            // The dictionary isolates the controller from concrete factories and centralizes lookup rules.
            _factories = factories.ToDictionary(
                factory => factory.ModelKey,
                factory => factory,
                StringComparer.OrdinalIgnoreCase);
        }

        public IReadOnlyCollection<VehicleFactoryOption> GetAvailableModels()
        {
            return _factories.Values
                .OrderBy(factory => factory.ModelKey)
                .Select(factory => new VehicleFactoryOption
                {
                    ModelKey = factory.ModelKey,
                    DisplayName = $"Add {factory.ModelKey}"
                })
                .ToList();
        }

        public Vehicle CreateVehicle(string modelKey)
        {
            if (string.IsNullOrWhiteSpace(modelKey) || !_factories.ContainsKey(modelKey))
            {
                throw new ArgumentException("Vehicle model is not supported", nameof(modelKey));
            }

            return _factories[modelKey].CreateVehicle();
        }
    }
}

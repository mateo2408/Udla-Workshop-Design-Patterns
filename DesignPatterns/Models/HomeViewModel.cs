using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.FactoryMethods;

namespace DesignPatterns.Models
{
    public class HomeViewModel
    {
        public ICollection<Vehicle> Vehicles { get; set; }
        public IReadOnlyCollection<VehicleFactoryOption> AvailableModels { get; set; }
    }
}

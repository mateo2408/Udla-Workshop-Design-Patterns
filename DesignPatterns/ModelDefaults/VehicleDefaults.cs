using System;
using System.Collections.Generic;

namespace DesignPatterns.ModelDefaults
{
    public static class VehicleDefaults
    {
        public static int CurrentYear => DateTime.Now.Year;

        public static IDictionary<string, string> CreateDefaultProperties()
        {
            return new Dictionary<string, string>
            {
                { "Origin", "Factory" },
                { "WarrantyStatus", "Pending" },
                { "InspectionStatus", "Pending" },
                { "RegistrationStatus", "Pending" }
            };
        }
    }
}

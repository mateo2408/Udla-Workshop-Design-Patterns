using DesignPatterns.Models;
using DesignPatterns.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace DesignPatterns.Infraestructure.Singleton
{
    public class MemoryCollection
    {
        public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

        private static MemoryCollection _instance;

        private MemoryCollection() { }

        public static MemoryCollection Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MemoryCollection();
                }
                return _instance;
            }
        }
    }
}
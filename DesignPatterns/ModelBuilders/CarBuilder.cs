using DesignPatterns.Models;

namespace DesignPatterns.ModelBuilders
{
    public class CarBuilder
    {
        private string color = "red";
        private string model = "Mustang";
        private string brand = "Ford";
        private int? year;


        public CarBuilder setColor(string color)
        {
            this.color = color;
            return this;
        }

        public CarBuilder setBrand(string brand)
        {
            this.brand = brand;
            return this;
        }

        public CarBuilder setModel(string model)
        {
            this.model = model;
            return this;
        }

        public CarBuilder setYear(int year)
        {
            this.year = year;
            return this;
        }
        
        public Vehicle Build()
        {
            var car = new Car(color, brand, model);

            if (year.HasValue)
            {
                car.Year = year.Value;
            }

            return car;
        }
    }
}

using DesignPatterns.ModelBuilders;

namespace DesignPatterns.FactoryMethods
{
    public class FordMustangFactory : CarFactory
    {
        protected override CarBuilder CreateBuilder()
        {
            return new CarBuilder()
                .setColor("Red")
                .setBrand("Ford")
                .setModel("Mustang");
        }
    }
}

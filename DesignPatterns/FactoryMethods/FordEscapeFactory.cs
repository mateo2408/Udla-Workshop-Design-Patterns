using DesignPatterns.ModelBuilders;

namespace DesignPatterns.FactoryMethods
{
    public class FordEscapeFactory : CarFactory
    {
        protected override CarBuilder CreateBuilder()
        {
            return new CarBuilder()
                .setColor("Red")
                .setBrand("Ford")
                .setModel("Escape");
        }
    }
}

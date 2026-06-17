using DesignPatterns.ModelBuilders;

namespace DesignPatterns.FactoryMethods
{
    public class FordExplorerFactory : CarFactory
    {
        protected override CarBuilder CreateBuilder()
        {
            return new CarBuilder()
                .setColor("Red")
                .setBrand("Ford")
                .setModel("Explorer");
        }
    }
}

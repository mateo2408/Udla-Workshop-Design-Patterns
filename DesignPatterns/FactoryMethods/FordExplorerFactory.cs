using DesignPatterns.ModelBuilders;

namespace DesignPatterns.FactoryMethods
{
    public class FordExplorerFactory : CarFactory
    {
        public override string ModelKey => "Explorer";

        protected override CarBuilder CreateBuilder()
        {
            return new CarBuilder()
                .setColor("Red")
                .setBrand("Ford")
                .setModel("Explorer");
        }
    }
}

using DesignPatterns.ModelBuilders;

namespace DesignPatterns.FactoryMethods
{
    public class FordEscapeFactory : CarFactory
    {
        public override string ModelKey => "Escape";

        protected override CarBuilder CreateBuilder()
        {
            return new CarBuilder()
                .setColor("Red")
                .setBrand("Ford")
                .setModel("Escape");
        }
    }
}

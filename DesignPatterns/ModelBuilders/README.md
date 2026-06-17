# Vehicle default properties

The current implementation uses a Builder plus Factory Method.

`VehicleDefaults` owns cross-cutting default values such as the current year and default vehicle metadata. When the next sprint adds 20 more properties, they can be added to `VehicleDefaults.CreateDefaultProperties()` without changing controllers, repositories, or concrete factories.

Concrete factories such as `FordMustangFactory`, `FordExplorerFactory`, and `FordEscapeFactory` only describe the model-specific values. The builder applies the shared defaults.

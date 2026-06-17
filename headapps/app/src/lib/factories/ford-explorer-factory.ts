import { VehicleBuilder } from "../builders/vehicle-builder";
import { CarFactory } from "./car-factory";

export class FordExplorerFactory extends CarFactory {
  protected createBuilder(): VehicleBuilder {
    return new VehicleBuilder()
      .setColor("Red")
      .setBrand("Ford")
      .setModel("Explorer");
  }
}

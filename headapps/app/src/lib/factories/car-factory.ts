import { VehicleBuilder } from "../builders/vehicle-builder";
import { Vehicle } from "../types/vehicle";

export abstract class CarFactory {
  createVehicle(): Vehicle {
    return this.createBuilder().build();
  }

  protected abstract createBuilder(): VehicleBuilder;
}

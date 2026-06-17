import { Vehicle } from "../types/vehicle";

const currentYear = () => new Date().getFullYear();

const defaultProperties = (): Record<string, string> => ({
  origin: "Factory",
  warrantyStatus: "Pending",
  inspectionStatus: "Pending",
  registrationStatus: "Pending",
});

export class VehicleBuilder {
  private vehicle: Vehicle = {
    id: crypto.randomUUID(),
    color: "Red",
    brand: "Ford",
    model: "Mustang",
    year: currentYear(),
    defaultProperties: defaultProperties(),
  };

  setColor(color: string) {
    this.vehicle.color = color;
    return this;
  }

  setBrand(brand: string) {
    this.vehicle.brand = brand;
    return this;
  }

  setModel(model: string) {
    this.vehicle.model = model;
    return this;
  }

  setYear(year: number) {
    this.vehicle.year = year;
    return this;
  }

  build(): Vehicle {
    return {
      ...this.vehicle,
      defaultProperties: { ...this.vehicle.defaultProperties },
    };
  }
}

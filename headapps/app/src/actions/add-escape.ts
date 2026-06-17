"use server";

import { FordEscapeFactory } from "@/lib/factories/ford-escape-factory";
import { VehicleService } from "@/lib/services/vehicle";
import { revalidatePath } from "next/cache";
import { redirect } from "next/navigation";

export async function addEscape() {
  const service = new VehicleService();
  service.add(new FordEscapeFactory().createVehicle());
  revalidatePath("/");
  redirect("/");
}

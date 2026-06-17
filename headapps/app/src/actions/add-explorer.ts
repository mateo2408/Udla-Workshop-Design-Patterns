"use server";

import { VehicleService } from "@/lib/services/vehicle";
import { FordExplorerFactory } from "@/lib/factories/ford-explorer-factory";
import { revalidatePath } from "next/cache";
import { redirect } from "next/navigation";

export async function addExplorer() {
 const service = new VehicleService();
 service.add(new FordExplorerFactory().createVehicle());
 revalidatePath("/");
 redirect("/");
}

import type { IBuildingUpgrade } from "@/interfaces/IBuildingUpgrade";
import type { ITown } from "@/interfaces/ITown";
import axios from "axios";

const apiInstance = axios.create({
  baseURL: "",
  timeout: 1000,
});

export async function fetchTown(id: number): Promise<ITown> {
  try {
    const response = await apiInstance.get(
      `http://localhost:5000/api/town/${id}`
    );
    console.log(response.data);
    return response.data;
  } catch (error) {
    console.error(`Can't load town with ${id}:`, error);
    throw error;
  }
}

export async function fetchBuildingUpgrade(
  id: number
): Promise<IBuildingUpgrade> {
  try {
    const response = await apiInstance.get(
      `http://localhost:5000/api/town/building_upgrade/${id}`
    );
    console.log(response.data);
    return response.data;
  } catch (error) {
    console.error(`Can't load building upgrade with ${id}:`, error);
    throw error;
  }
}

export async function postUpgradeBuilding(
  townId: number,
  instanceId: number
): Promise<ITown> {
  try {
    const response = await apiInstance.post(
      `http://localhost:5000/api/town/building_instance_upgrade/${townId}/${instanceId}`
    );
    console.log(response.data);
    return response.data;
  } catch (error) {
    console.error(`Can't post upgrade with ${instanceId}:`, error);
    throw error;
  }
}

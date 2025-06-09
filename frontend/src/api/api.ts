import type { ITown } from "@/interfaces/ITown";
import axios from "axios";

const apiInstance = axios.create({
  baseURL: "",
  timeout: 1000,
});

export async function fetchTown(id: number): Promise<ITown> {
  try {
    const response = await apiInstance.get(`http://localhost:5000/api/town/1`);
    console.log(response.data);
    return response.data;
  } catch (error) {
    console.error(`Can't load town with ${id}:`, error);
    throw error;
  }
}

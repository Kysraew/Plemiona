import type { IBuilding } from "./IBuilding";
import type { ITown } from "./ITown";

export interface IBuildingInstance {
  buildingInstanceId: number;
  level: number;
  buildingId: number;
  building: IBuilding;
  townId: number;
  town?: ITown;
}

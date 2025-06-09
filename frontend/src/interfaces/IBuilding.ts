import type { IBuildingUpgrade } from "./IBuildingUpgrade";

export interface IBuilding {
  buildingId: number;
  name: string;
  description: string;
  buildingUpgrades: IBuildingUpgrade[];
}

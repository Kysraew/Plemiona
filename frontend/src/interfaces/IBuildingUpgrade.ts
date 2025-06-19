export interface IBuildingUpgrade {
  buildingUpgradeId: number;
  buildingId: number;
  durationSeconds: number;
  level: number;
  gold: number;
  wood: number;
  stone: number;
  iron: number;
  populationNeeded: number;
  grainPerEmployee: number;
}

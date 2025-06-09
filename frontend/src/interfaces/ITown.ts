import type { IBuildingInstance } from "./IBuildingInstance";
import type { IPlayer } from "./IPlayer";

export interface ITown {
  townId: number;
  name: string;
  population: number;
  xCoordinate: number;
  yCoordinate: number;
  buildingInstances: IBuildingInstance[];
  playerId: number;
  player?: IPlayer;
}

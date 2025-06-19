import type { ITown } from "./ITown";

export interface IPlayer {
  playerId: number;
  name: string;
  grain: number;
  gold: number;
  stone: number;
  wood: number;
  iron: number;
  Towns?: ITown[];
}

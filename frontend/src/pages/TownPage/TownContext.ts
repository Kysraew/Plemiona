import type { ITown } from "@/interfaces/ITown";
import { createContext, useContext } from "react";

export type TownContext = {
  town: ITown | null;
  selectedBuilding: string | null;
  setSelectedBuilding: (c: string | null) => void;
};

export const MyTownContext = createContext<TownContext>({
  town: null,
  selectedBuilding: null,
  setSelectedBuilding: () => {},
});

export const useTownContext = () => useContext(MyTownContext);

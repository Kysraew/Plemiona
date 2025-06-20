import type { IBuildingInstance } from "@/interfaces/IBuildingInstance";
import type { ITown } from "@/interfaces/ITown";
import { createContext, useContext } from "react";

export type TownContext = {
  town: ITown | null;
  setTown: (c: ITown | null) => void;
  selectedBuildingInstance: IBuildingInstance | null;
  setSelectedBuildingInstance: (c: IBuildingInstance | null) => void;
};

export const MyTownContext = createContext<TownContext>({
  town: null,
  setTown: () => {},
  selectedBuildingInstance: null,
  setSelectedBuildingInstance: () => {},
});

export const useTownContext = () => useContext(MyTownContext);

import TownMap from "@/components/TownMap/TownMap";
import styles from "./TownPage.module.css";
import NavBar from "@/components/NavBar/NavBar";
import TownPanel from "@/components/TownPanel/TownPanel";
import { createContext, useContext, useState } from "react";

interface TownContextValue {
  selectedBuildingName: string | null;
  selectedBuildingDescription: string | null;
  selectedBuildingLevel: number;
}

export const TownContext = createContext<TownContextValue | null>(null);

const TownPage = () => {
  const [currentTownContext, setCurrentTownContext] =
    useState<TownContextValue>({
      selectedBuildingName: "Woods",
      selectedBuildingDescription: "Test test",
      selectedBuildingLevel: 2,
    });

  return (
    <div>
      <NavBar />
      <h2 className={styles.townHeader}>Town</h2>
      <TownContext.Provider value={currentTownContext}>
        <div className={styles.mainTownView}>
          <div className={styles.townMap}>
            <TownMap />
          </div>
          <div className={styles.townPanel}>
            <TownPanel />
          </div>
        </div>
      </TownContext.Provider>
    </div>
  );
};

export default TownPage;

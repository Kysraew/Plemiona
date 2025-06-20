import TownMap from "@/components/TownMap/TownMap";
import styles from "./TownPage.module.css";
import NavBar from "@/components/NavBar/NavBar";
import TownPanel from "@/components/TownPanel/TownPanel";
import { createContext, useContext, useEffect, useState } from "react";
import type { ITown } from "@/interfaces/ITown";
import { fetchTown } from "@/api/api";
import { MyTownContext } from "./TownContext";
import type { IBuildingInstance } from "@/interfaces/IBuildingInstance";
import TownResources from "@/components/TownResources/TownResources";
const townID = 1;

const TownPage = () => {
  const [town, setTown] = useState<ITown | null>(null);
  const [selectedBuilding, setSelectedBuilding] =
    useState<IBuildingInstance | null>(null);

  useEffect(() => {
    let ignore = false;
    setTown(null);
    fetchTown(townID).then((result) => {
      if (!ignore) {
        setTown(result);
        console.log("Result: ", result);
      }
    });
    return () => {
      ignore = true;
    };
  }, []);

  return (
    <div>
      <NavBar />
      <MyTownContext.Provider
        value={{
          town,
          setTown,
          selectedBuildingInstance: selectedBuilding,
          setSelectedBuildingInstance: setSelectedBuilding,
        }}
      >
        <TownResources />
        <div className={styles.mainTownView}>
          <div className={styles.townMap}>
            <TownMap />
          </div>
          <div className={styles.townPanel}>
            <TownPanel />
          </div>
        </div>
      </MyTownContext.Provider>
    </div>
  );
};

export default TownPage;

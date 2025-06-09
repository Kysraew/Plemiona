import TownMap from "@/components/TownMap/TownMap";
import styles from "./TownPage.module.css";
import NavBar from "@/components/NavBar/NavBar";
import TownPanel from "@/components/TownPanel/TownPanel";
import { createContext, useContext, useEffect, useState } from "react";
import type { ITown } from "@/interfaces/ITown";
import { fetchTown } from "@/api/api";

const townID = 1;

const TownPage = () => {
  const [town, setTown] = useState<ITown | null>(null);
  const [selectedBuilding, setSelectedBuilding] = useState<string | null>(null);

  useEffect(() => {
    let ignore = false;
    setTown(null);
    fetchTown(townID).then((result) => {
      if (!ignore) {
        setTown(result);
        console.log(result);
      }
    });
    return () => {
      ignore = true;
    };
  }, []);

  return (
    <div>
      <NavBar />
      <h2 className={styles.townHeader}>Town</h2>
      <div className={styles.mainTownView}>
        <div className={styles.townMap}>
          <TownMap />
        </div>
        <div className={styles.townPanel}>
          <TownPanel />
          <>{town}</>
        </div>
      </div>
    </div>
  );
};

export default TownPage;

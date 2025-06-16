import React, { useContext } from "react";
import styles from "./TownPanel.module.css";
import type { ITown } from "@/interfaces/ITown";
import { useTownContext } from "@/pages/TownPage/TownContext";

const TownPanel = () => {
  const { town, selectedBuilding, setSelectedBuilding } = useTownContext();

  if (town === null) {
    return <div className={styles.panelContainer}>Can't load town</div>;
  }

  if (selectedBuilding === null) {
    return (
      <div className={styles.panelContainer}>Select building to see info</div>
    );
  }

  return (
    <div className={styles.panelContainer}>
      <p>{town.name}</p>
    </div>
  );
};

export default TownPanel;

import React, { useContext } from "react";
import styles from "./TownPanel.module.css";
import BuildingContext from "../BuildingContext/BuildingContext";
import { TownContext } from "@/pages/TownPage/TownPage";

const TownPanel = () => {
  const currentTownContext = useContext(TownContext);

  if (currentTownContext === null) {
    return <div className={styles.panelContainer}></div>;
  }

  return (
    <div className={styles.panelContainer}>
      <BuildingContext
        buildingName={currentTownContext.selectedBuildingName ?? ""}
        buildingDescription={
          currentTownContext.selectedBuildingDescription ?? ""
        }
      />
    </div>
  );
};

export default TownPanel;

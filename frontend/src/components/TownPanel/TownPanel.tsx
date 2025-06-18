import React, { useContext } from "react";
import styles from "./TownPanel.module.css";
import type { ITown } from "@/interfaces/ITown";
import { useTownContext } from "@/pages/TownPage/TownContext";
import BuildingContext from "../BuildingContext/BuildingContext";

const TownPanel = () => {
  return (
    <div className={styles.panelContainer}>
      <BuildingContext />
    </div>
  );
};

export default TownPanel;

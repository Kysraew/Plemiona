import styles from "./TownPanel.module.css";
import BuildingContext from "../BuildingContext/BuildingContext";

const TownPanel = () => {
  return (
    <div className={styles.panelContainer}>
      <BuildingContext />
    </div>
  );
};

export default TownPanel;

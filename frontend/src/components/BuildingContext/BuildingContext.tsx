import styles from "./BuildingContext.module.css";
import { useTownContext } from "@/pages/TownPage/TownContext";

const BuildingContext = () => {
  const { town, selectedBuildingInstance } = useTownContext();

  if (town === null) {
    return (
      <div className={styles.panelContainer}>
        <p className={styles.buildingDescriptionParagraph}>Can't load town</p>
      </div>
    );
  }

  if (selectedBuildingInstance === null) {
    return (
      <div className={styles.panelContainer}>
        <p className={styles.buildingDescriptionParagraph}>
          Select building to see info
        </p>
      </div>
    );
  }
  return (
    <>
      <h3 className={styles.buildingNameHeader}>
        {selectedBuildingInstance?.building.name}
      </h3>
      <div className={styles.buildingDescriptionParagraph}>
        <p>{selectedBuildingInstance?.building.description}</p>
        <p>
          <b>Current level:</b> {selectedBuildingInstance?.level}
        </p>
      </div>

      <button className={styles.upgradeButton}>Upgrade</button>
    </>
  );
};

export default BuildingContext;

import React from "react";
import styles from "./TownMap.module.css";
import backgroundTownImage from "/buildingImages/BackgroundTown.png";
import wallImage from "/buildingImages/Wall.png";
import { useTownContext } from "@/pages/TownPage/TownContext";

const buildingImages: { [key: string]: string } = {
  Wall: wallImage,
};

const TownMap = () => {
  const { town, setSelectedBuildingInstance: setSelectedBuilding } =
    useTownContext();

  return (
    <div className={styles.townMapContainer}>
      <img
        className={styles.backgroundImage}
        src={backgroundTownImage}
        alt="backgroundTown"
      />
      {town?.buildingInstances.map((instance) => (
        <>
          <img
            className={styles.topImage}
            src={buildingImages[instance.building.name]}
            alt="wall"
          />
          <div
            className={`${styles.clickContainer} ${
              styles[instance.building.name.toLowerCase()]
            }`}
            onClick={() => setSelectedBuilding(instance)}
            title={instance.building.name}
          />
        </>
      ))}
    </div>
  );
};

export default TownMap;

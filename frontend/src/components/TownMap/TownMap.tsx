import React from "react";
import styles from "./TownMap.module.css";
import { useTownContext } from "@/pages/TownPage/TownContext";

import backgroundImage from "/buildingImages/Background.png";
import BaracsImage from "/buildingImages/Baracs.png";
import FieldImage from "/buildingImages/Field.png";
import ForgeImage from "/buildingImages/Forge.png";
import MineImage from "/buildingImages/Mine.png";
import SawmillImage from "/buildingImages/Sawmill.png";
import StonepitImage from "/buildingImages/Stonepit.png";
import TownHallImage from "/buildingImages/TownHall.png";
import WallImage from "/buildingImages/Wall.png";

const buildingImages: { [key: string]: string } = {
  Baracs: BaracsImage,
  Field: FieldImage,
  Forge: ForgeImage,
  Mine: MineImage,
  Sawmill: SawmillImage,
  Stonepit: StonepitImage,
  Townhall: TownHallImage,
  Wall: WallImage,
};

const TownMap = () => {
  const { town, setSelectedBuildingInstance: setSelectedBuilding } =
    useTownContext();

  return (
    <div className={styles.townMapContainer}>
      <img
        className={styles.backgroundImage}
        src={backgroundImage}
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
          >
            <span>
              {instance.building.name} Lev. {instance.level}
            </span>
          </div>
        </>
      ))}
    </div>
  );
};

export default TownMap;

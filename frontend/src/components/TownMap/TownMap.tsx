import React from "react";
import styles from "./TownMap.module.css";
import backgroundTown from "/BackgroundTown.png";
import wall from "/Wall.png";




const TownMap = () => {
  return (
    <div className={styles.townMapContainer}>
      <img
        className={styles.backgroundImage}
        src={backgroundTown}
        alt="backgroundTown"
      />
      <img className={styles.topImage} src={wall} alt="wall" />
    </div>
  );
};

export default TownMap;

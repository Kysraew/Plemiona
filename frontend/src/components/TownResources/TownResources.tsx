import React from "react";
import styles from "./TownRecources.module.css";
import { useTownContext } from "@/pages/TownPage/TownContext";

import grainIcon from "/resourceIcons/grainIcon.png";
import ironIcon from "/resourceIcons/ironIcon.png";
import populationIcon from "/resourceIcons/populationIcon.png";
import stoneIcon from "/resourceIcons/stoneIcon.png";
import woodIcon from "/resourceIcons/woodIcon.png";

const TownResources = () => {
  const { town } = useTownContext();

  return (
    <div className={styles.resourcesContainer}>
      <div className={styles.resourceContainer}>
        <img className={styles.resourceImage} src={grainIcon} alt="grainIcon" />
        <span className={styles.resource}>{town?.player?.grain}</span>
      </div>
      <div className={styles.resourceContainer}>
        <img className={styles.resourceImage} src={ironIcon} alt="ironIcon" />
        <span className={styles.resource}>{town?.player?.iron}</span>
      </div>
      <div className={styles.resourceContainer}>
        <img
          className={styles.resourceImage}
          src={populationIcon}
          alt="populationIcon"
        />
        <span className={styles.resource}>{town?.population}</span>
      </div>
      <div className={styles.resourceContainer}>
        <img className={styles.resourceImage} src={stoneIcon} alt="stoneIcon" />
        <span className={styles.resource}>{town?.player?.stone}</span>
      </div>
      <div className={styles.resourceContainer}>
        <img className={styles.resourceImage} src={woodIcon} alt="woodIcon" />
        <span className={styles.resource}>{town?.player?.wood}</span>
      </div>
    </div>
  );
};

export default TownResources;

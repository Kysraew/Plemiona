import React from "react";
import styles from "./BuildingContext.module.css";

interface Props {
  buildingName: string;
  buildingDescription: string;
}

const BuildingContext = ({ buildingName, buildingDescription }: Props) => {
  return (
    <>
      <h3 className={styles.buildingNameHeader}>{buildingName}</h3>
      <p className={styles.buildingDescriptionParagraph}>
        {buildingDescription}
      </p>
      <button className={styles.upgradeButton}>Upgrade</button>
    </>
  );
};

export default BuildingContext;

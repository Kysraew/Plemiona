import { useEffect, useState } from "react";
import styles from "./BuildingContext.module.css";
import { useTownContext } from "@/pages/TownPage/TownContext";
import type { IBuildingUpgrade } from "@/interfaces/IBuildingUpgrade";
import { fetchBuildingUpgrade, postUpgradeBuilding } from "@/api/api";

const TownId = 1;

const BuildingContext = () => {
  const { town, setTown, selectedBuildingInstance } = useTownContext();

  const [buildingUpgrade, setBuildingUpgrade] =
    useState<IBuildingUpgrade | null>(null);

  useEffect(() => {
    if (selectedBuildingInstance?.level !== undefined) {
      let ignore = false;
      setBuildingUpgrade(null);
      fetchBuildingUpgrade(selectedBuildingInstance?.level).then((result) => {
        if (!ignore) {
          setBuildingUpgrade(result);
          console.log("Result: ", result);
        }
      });
      return () => {
        ignore = true;
      };
    }
  }, [selectedBuildingInstance]);

  const upgradeBuilding = () => {
    useEffect(() => {
      if (selectedBuildingInstance?.level !== undefined) {
        let ignore = false;
        postUpgradeBuilding(
          TownId,
          selectedBuildingInstance?.buildingInstanceId
        ).then((result) => {
          if (!ignore) {
            setTown(result);
            console.log("Result: ", result);
          }
        });
        return () => {
          ignore = true;
        };
      }
    }, [selectedBuildingInstance]);
  };

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
      <br />
      <p>
        <b>Next level cost:</b>
      </p>
      <ul>
        <li>
          <b>Gold: </b> {buildingUpgrade?.gold}
        </li>
        <li>
          <b>Iron: </b> {buildingUpgrade?.iron}
        </li>
        <li>
          <b>Stone: </b> {buildingUpgrade?.stone}
        </li>
        <li>
          <b>Wood: </b> {buildingUpgrade?.wood}
        </li>
        <li>
          <b>Total max workers: </b> {buildingUpgrade?.populationNeeded}
        </li>
        <li>
          <b>Grain per person: </b> {buildingUpgrade?.grainPerEmployee}
        </li>
      </ul>
      <button className={styles.upgradeButton}>Upgrade</button>
    </>
  );
};

export default BuildingContext;

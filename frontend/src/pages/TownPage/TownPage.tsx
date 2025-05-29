import TownMap from "@/components/TownMap/TownMap";
import styles from "./TownPage.module.css";
import NavBar from "@/components/NavBar/NavBar";
import TownPanel from "@/components/TownPanel/TownPanel";

const TownPage = () => {
  return (
    <div>
      <NavBar />
      <h2 className={styles.townHeader}>Town</h2>
      <div className={styles.mainTownView}>
        <div className={styles.townMap}>
          <TownMap />
        </div>
        <div className={styles.townPanel}>
          <TownPanel />
        </div>
      </div>
    </div>
  );
};

export default TownPage;

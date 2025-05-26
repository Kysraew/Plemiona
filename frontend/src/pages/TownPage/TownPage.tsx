import TownMap from "@/components/TownMap/TownMap";
import styles from "./TownPage.module.css";
import NavBar from "@/components/NavBar/NavBar";

const TownPage = () => {
  return (
    <div>
      <NavBar />
      <h2>Town</h2>
      <TownMap />
    </div>
  );
};

export default TownPage;

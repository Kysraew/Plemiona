import React from "react";
import { Link } from "react-router-dom";
import styles from "./NavBar.module.css";

const NavBar = () => {
  return (
    <nav className={styles.navbar}>
      <ul>
        <li>
          <Link to="/town">Town</Link>
        </li>
        <li>
          <Link to="/map">Map</Link>
        </li>
        <li>
          <Link to="/alliance">Alliance</Link>
        </li>
      </ul>
    </nav>
  );
};

export default NavBar;

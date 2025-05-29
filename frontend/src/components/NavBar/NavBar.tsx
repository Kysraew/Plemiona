import React from "react";
import { NavLink } from "react-router-dom";
import styles from "./NavBar.module.css";

const NavBar = () => {
  return (
    <nav className={styles.navbar}>
      <ul>
        <li>
          <NavLink
            className={({ isActive }) =>
              isActive ? styles.linkActive : styles.link
            }
            to="/town"
          >
            Town
          </NavLink>
        </li>
        <li>
          <NavLink
            className={({ isActive }) =>
              isActive ? styles.linkActive : styles.link
            }
            to="/map"
          >
            Map
          </NavLink>
        </li>
        <li>
          <NavLink
            className={({ isActive }) =>
              isActive ? styles.linkActive : styles.link
            }
            to="/alliance"
          >
            Alliance
          </NavLink>
        </li>
      </ul>
    </nav>
  );
};

export default NavBar;

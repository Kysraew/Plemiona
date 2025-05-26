import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import AuthPage from "@/pages/AuthPage/AuthPage";
import TownPage from "@/pages/TownPage/TownPage";
import MapPage from "@/pages/MapPage/MapPage";
import Alliance from "./pages/AlliancePage/Alliance";

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/auth" element={<AuthPage />} />
        <Route path="/town" element={<TownPage />} />
        <Route path="/map" element={<MapPage />} />
        <Route path="/alliance" element={<Alliance />} />
      </Routes>
    </Router>
  );
}

export default App;


using backend.core.Models;

namespace backend.core.BussinessLogic
{
  public static class TownLogic
  {
    public static bool UpgradeBuilding(Town town, BuildingInstance buildingInstance, BuildingUpgrade buildingUpgrade)
    {
      int remainedGold = town.Player.Gold - buildingUpgrade.Gold;
      int remainedWood = town.Player.Wood - buildingUpgrade.Wood;
      int remainedStone = town.Player.Stone - buildingUpgrade.Stone;
      int remainedIron = town.Player.Iron - buildingUpgrade.Iron;

      if (remainedGold >= 0
      && remainedWood >= 0
      && remainedStone >= 0
      && remainedIron >= 0)
      {
        town.Player.Gold = remainedGold;
        town.Player.Wood = remainedWood;
        town.Player.Stone = remainedStone;
        town.Player.Iron = remainedIron;
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}

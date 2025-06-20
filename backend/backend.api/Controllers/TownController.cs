using Microsoft.AspNetCore.Mvc;
using backend.core.Models;
using backend.core.BussinessLogic;

namespace WebApp.Controllers
{


  [Route("api/[controller]")]
  public class TownController : ControllerBase
  {
    private const long TownID = 1;

    private IUnitOfWork _unitOfWork;
    public TownController(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IAsyncEnumerable<Town> GetTowns()
    {
      return _unitOfWork.Towns.GetAllAsync();
    }

    [HttpGet("{id}")]
    public async Task<Town?> GetProduct(long id)
    {
      return await _unitOfWork.Towns.GetById(id);
    }

    [HttpGet("building_upgrade/{id}")]
    public async Task<BuildingUpgrade?> GetBuildingUpgrade(long id)
    {
      return await _unitOfWork.BuildingUpgrades.GetById(id);
    }

    [HttpPost("building_instance_upgrade/{townId}/{instanceId}")]
    public async Task<Town?> GetBuildingUpgrade(long townId, long instanceId)
    {

      BuildingInstance? buildingInstance = await _unitOfWork.BuildingInstances.GetById(instanceId);
      Town? town = await _unitOfWork.Towns.GetById(townId);

      if (buildingInstance == null || town == null)
      {
        return null;
      }

      BuildingUpgrade? buildingUpgrade = await _unitOfWork.BuildingUpgrades.GetByBuildingLevel(buildingInstance.BuildingId, buildingInstance.Level + 1);

      if (buildingUpgrade == null)
      {
        return null;
      }

      bool updated = TownLogic.UpgradeBuilding(town, buildingInstance, buildingUpgrade);

      if (!updated)
      {
        return null;
      }

      buildingInstance.Level += 1;

      await _unitOfWork.BuildingInstances.Update(buildingInstance);
      await _unitOfWork.Towns.Update(town);

      await _unitOfWork.CompleteAsync();
      return await _unitOfWork.Towns.GetById(townId);
    }

  }
}
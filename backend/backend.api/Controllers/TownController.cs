using Microsoft.AspNetCore.Mvc;
using backend.core.Models;

namespace WebApp.Controllers
{

  [Route("api/[controller]")]
  public class TownController : ControllerBase
  {

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


  }
}
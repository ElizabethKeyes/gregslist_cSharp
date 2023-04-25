using gregslist_cSharp.Controllers;

namespace gregslist_cSharp.Services;

public class HousesService
{
  private readonly HousesRepository _housesRepo;
  public HousesService(HousesRepository housesRepo)
  {
    _housesRepo = housesRepo;
  }

  internal List<House> GetHouses()
  {
    List<House> houses = _housesRepo.GetHouses();
    return houses;
  }
}
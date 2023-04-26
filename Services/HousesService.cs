using gregslist_cSharp.Controllers;

namespace gregslist_cSharp.Services;

public class HousesService
{
  private readonly HousesRepository _housesRepo;
  public HousesService(HousesRepository housesRepo)
  {
    _housesRepo = housesRepo;
  }

  internal House CreateHouse(House houseData)
  {
    int id = _housesRepo.CreateHouse(houseData);
    House house = this.GetHouseById(id);
    return house;
  }

  internal House GetHouseById(int houseId)
  {
    House house = _housesRepo.GetHouseById(houseId);
    if (house == null)
    {
      throw new Exception($"No house found at id {houseId}");
    }
    return house;
  }

  internal List<House> GetHouses()
  {
    List<House> houses = _housesRepo.GetHouses();
    return houses;
  }
}
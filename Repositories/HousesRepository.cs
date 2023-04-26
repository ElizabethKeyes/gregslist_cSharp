using gregslist_cSharp.Controllers;

namespace gregslist_cSharp.Repositories;

public class HousesRepository
{
  private readonly IDbConnection _db;

  public HousesRepository(IDbConnection db)
  {
    _db = db;
  }

  internal House GetHouseById(int houseId)
  {
    string sql = "SELECT * FROM houses WHERE id = @houseId;";
    House house = _db.Query<House>(sql, new { houseId }).FirstOrDefault();
    return house;
  }

  internal List<House> GetHouses()
  {
    string sql = "SELECT * FROM houses";
    List<House> houses = _db.Query<House>(sql).ToList();
    return houses;
  }
}
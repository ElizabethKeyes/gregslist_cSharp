using gregslist_cSharp.Controllers;

namespace gregslist_cSharp.Repositories;

public class HousesRepository
{
  private readonly IDbConnection _db;

  public HousesRepository(IDbConnection db)
  {
    _db = db;
  }

  internal int CreateHouse(House houseData)
  {
    string sql = @"
    INSERT INTO houses(
        levels, bedrooms, bathrooms, price, description, imgUrl
        )
      values(
        @Levels, @Bedrooms, @Bathrooms, @Price, @Description, @ImgUrl
        );
    SELECT LAST_INSERT_ID();";
    int id = _db.ExecuteScalar<int>(sql, houseData);
    return id;
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
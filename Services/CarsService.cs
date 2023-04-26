namespace gregslist_cSharp.Services;

public class CarsService
{
  private readonly CarsRepository _carsRepo;

  public CarsService(CarsRepository carsRepo)
  {
    _carsRepo = carsRepo;
  }

  internal Car CreateCar(Car carData)
  {
    int id = _carsRepo.CreateCar(carData);

    Car car = this.GetOne(id);

    return car;
  }

  internal Car EditCar(Car carData, int carId)
  {
    Car originalCar = this.GetOne(carId);

    originalCar.Make = carData.Make ?? originalCar.Make;
    originalCar.Model = carData.Model ?? originalCar.Model;
    originalCar.Price = carData.Price ?? originalCar.Price;
    originalCar.HasTires = carData.HasTires != null ? carData.HasTires : originalCar.HasTires;

    _carsRepo.EditCar(originalCar);

    originalCar.UpdatedAt = DateTime.Now;

    return originalCar;
  }

  internal List<Car> GetAll()
  {
    List<Car> cars = _carsRepo.GetAll();
    return cars;
  }

  internal Car GetOne(int carId)
  {
    Car car = _carsRepo.GetOne(carId);
    if (car == null)
    {
      throw new Exception($"THIS ID SUCKS: {carId}");
    }
    return car;
  }

  internal string Remove(int carId)
  {
    Car car = this.GetOne(carId);
    int rowsAffected = _carsRepo.Remove(carId);
    return $"{car.Make + ' ' + car.Model} is toast, bud." + ' ' + "🏎️🔥";

    // NOTE we don't have to do this!

    // if (rowsAffected == 0)
    // {
    //   throw new Exception("DELETE FAILED... ????");
    // }

    // NOTE we don't have to do this!

    // if (rowsAffected > 1)
    // {
    //   throw new Exception("CALL MICK");
    // }

  }
}

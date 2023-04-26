namespace gregslist_cSharp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarsController : ControllerBase
{


  private readonly CarsService _carsService;

  public CarsController(CarsService carsService)
  {
    _carsService = carsService;
  }

  [HttpGet]
  public ActionResult<List<Car>> GetAll()
  {
    try
    {
      List<Car> cars = _carsService.GetAll();
      return Ok(cars);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{carId}")]
  public ActionResult<Car> GetOne(int carId)
  {
    try
    {
      Car car = _carsService.GetOne(carId);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost]
  public ActionResult<Car> CreateCar([FromBody] Car carData)
  {
    try
    {
      Car car = _carsService.CreateCar(carData);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPut("{carId}")]
  public ActionResult<Car> EditCar([FromBody] Car carData, int carId)
  {
    try
    {
      carData.Id = carId;
      Car car = _carsService.EditCar(carData, carId);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{carId}")]
  public ActionResult<string> Remove(int carId)
  {
    try
    {
      string message = _carsService.Remove(carId);
      return Ok(message);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}

namespace gregslist_cSharp.Controllers;

public class House
{
  public int Id { get; set; }
  public int Levels { get; set; }
  public int? Bedrooms { get; set; }
  public int? Bathrooms { get; set; }
  public int? Price { get; set; }
  public string Description { get; set; }
  public string ImgUrl { get; set; }
}
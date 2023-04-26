namespace gregslist_cSharp.Models;

public class Job
{
  public int Id { get; set; }
  public string Title { get; set; }
  public string Description { get; set; }
  public int? Rate { get; set; }
  public string Company { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}
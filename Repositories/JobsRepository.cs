namespace gregslist_cSharp.Repositories;

public class JobsRepository
{
  private readonly IDbConnection _db;
  public JobsRepository(IDbConnection db)
  {
    _db = db;
  }

  internal List<Job> GetJobs()
  {
    string sql = "SELECT * FROM jobs;";
    List<Job> jobs = _db.Query<Job>(sql).ToList();
    return jobs;
  }
}
namespace gregslist_cSharp.Repositories;

public class JobsRepository
{
  private readonly IDbConnection _db;
  public JobsRepository(IDbConnection db)
  {
    _db = db;
  }

  internal int CreateJob(Job jobData)
  {
    string sql = @"
    INSERT INTO jobs(
      title, description, rate, company
    )
    values(
      @Title, @Description, @Rate, @Company
    );
    SELECT LAST_INSERT_ID();";

    int id = _db.ExecuteScalar<int>(sql, jobData);
    return id;
  }

  internal Job GetJobById(int jobId)
  {
    string sql = "SELECT * FROM jobs WHERE id = @jobId LIMIT 1;";
    Job job = _db.Query<Job>(sql, new { jobId }).FirstOrDefault();
    return job;
  }

  internal List<Job> GetJobs()
  {
    string sql = "SELECT * FROM jobs;";
    List<Job> jobs = _db.Query<Job>(sql).ToList();
    return jobs;
  }
}
namespace gregslist_cSharp.Services;

public class JobsService
{
  private readonly JobsRepository _jobsRepo;
  public JobsService(JobsRepository jobsRepo)
  {
    _jobsRepo = jobsRepo;
  }

  internal Job CreateJob(Job jobData)
  {
    int id = _jobsRepo.CreateJob(jobData);
    Job job = this.GetJobById(id);
    return job;
  }

  internal Job GetJobById(int jobId)
  {
    Job job = _jobsRepo.GetJobById(jobId);
    return job;
  }

  internal List<Job> GetJobs()
  {
    List<Job> jobs = _jobsRepo.GetJobs();
    return jobs;
  }
}
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

  internal string DeleteJob(int jobId)
  {
    Job job = this.GetJobById(jobId);
    int rowsAffected = _jobsRepo.DeleteJob(jobId);
    return $"{job.Title} has been deleted";
  }

  internal Job EditJob(int jobId, Job jobData)
  {
    Job ogJob = this.GetJobById(jobId);
    ogJob.Title = jobData.Title ?? ogJob.Title;
    ogJob.Description = jobData.Description ?? ogJob.Description;
    ogJob.Rate = jobData.Rate ?? ogJob.Rate;
    _jobsRepo.EditJob(ogJob);
    ogJob.UpdatedAt = DateTime.Now;
    return ogJob;
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
namespace gregslist_cSharp.Controllers;

[ApiController]
[Route("api/jobs")]

public class JobsController : ControllerBase
{
  private readonly JobsService _jobsService;
  public JobsController(JobsService jobsService)
  {
    _jobsService = jobsService;
  }

  [HttpPost]
  public ActionResult<Job> CreateJob([FromBody] Job jobData)
  {
    try
    {
      Job job = _jobsService.CreateJob(jobData);
      return Ok(job);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{jobId}")]
  public ActionResult<string> DeleteJob(int jobId)
  {
    try
    {
      string message = _jobsService.DeleteJob(jobId);
      return Ok(message);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPut("{jobId}")]
  public ActionResult<Job> EditJob(int jobId, [FromBody] Job jobData)
  {
    try
    {
      Job job = _jobsService.EditJob(jobId, jobData);
      return Ok(job);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet]
  public ActionResult<List<Job>> GetJobs()
  {
    try
    {
      List<Job> jobs = _jobsService.GetJobs();
      return Ok(jobs);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{jobId}")]
  public ActionResult<Job> GetJobById(int jobId)
  {
    try
    {
      Job job = _jobsService.GetJobById(jobId);
      return Ok(job);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

}
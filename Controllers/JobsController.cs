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

}
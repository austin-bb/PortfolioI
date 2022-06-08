using Microsoft.AspNetCore.Mvc;
namespace PortfolioI.Controllers;

  public class HelloController : Controller
  {
    [HttpGet("")]
    public string Index()
    {
      return "This is my Index!";
    }

    [HttpGet("projects")]
    public string Projects()
    {
      return "These are my Projects!";
    }

    [HttpGet("contact")]
    public string Contact()
    {
      return "This is my Contact!";
    }
  }
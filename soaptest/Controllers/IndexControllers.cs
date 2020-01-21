using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace soaptest.Controllers
{

  [Route("api/[controller]/[action]")]
  public class IndexController : ControllerBase
  {
      [HttpGet]
      public string Getname(string name)
      {
          return name;
      }
  }
}
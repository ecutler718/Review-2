using Nancy;
using CountProject.Objects;
using System.Collections.Generic;

namespace CountProject
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => View["index.cshtml"];
      Post["/result"] = _ =>
      {
        Count newCount = new Count(Request.Form["Input"], Request.Form["CheckAgainst"]);
        int result = newCount.Repeats();
        return View["result.cshtml", result];
      };
    }
  }
}

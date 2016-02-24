using Nancy;
using CountRepeatProject.Objects;
using System.Collections.Generic;

namespace CountRepeatProject
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => View["index.cshtml"];
      Post["/result"] = _ =>
      {
        RepeatCounter newRepeatCounter = new RepeatCounter(Request.Form["Input"], Request.Form["CheckAgainst"]);
        int result = newRepeatCounter.CountRepeats();
        return View["result.cshtml", result];
      };
    }
  }
}

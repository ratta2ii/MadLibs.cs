using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
// Both of the next 2 Methods will work in unison to complete a form and display it's data.

    [Route("/form")]
    public ActionResult Form() { return View(); }

// The /story route comes from the action attribute within the form element (<form action="/story" method="post">) 
// The name attribute from the input fields within a form, will be passed in as arguments to set the value of 
// the properites in each instance. ( <input id="noun" name="noun" type="text"> ). See arguments below.

    [Route("/story")]    
    public ActionResult Story(string noun, string verb, string adjective)
    {
      MadLibsVariables myMadLibsInstance = new MadLibsVariables();
      myMadLibsInstance.Noun = noun;
      myMadLibsInstance.Verb = verb;
      myMadLibsInstance.Adjective = adjective;
      return View(myMadLibsInstance);
    }

  }
}




using Microsoft.AspNetCore.Mvc;
using MagicComputers.Models;

namespace MagicComputers.Controllers
{
  public class HomeController : Controller
  {

    // [Route("/")] //same as empty
    // public ActionResult Form() 
    // {
    //   return View();
    // }

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/adlib")]
    public ActionResult AdLib(string noun, string pluralNoun1, string presentTenseVerb, string bodyPart, string adjective1, string pluralNoun2, string adjective2)
    {
    AdLibVariable myadlibVariable = new AdLibVariable();
    myadlibVariable.Noun = noun;
    myadlibVariable.PluralNoun1 = pluralNoun1;
    myadlibVariable.PresentTenseVerb = presentTenseVerb;
    myadlibVariable.BodyPart = bodyPart;
    myadlibVariable.Adjective1 = adjective1;
    myadlibVariable.PluralNoun2 = pluralNoun2;
    myadlibVariable.Adjective2 = adjective2;
    return View(myadlibVariable);
    }

  }
}
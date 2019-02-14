using System.Web.Mvc;
using EasyReact.Feature.Example.Models;

namespace EasyReact.Feature.Example.Controllers
{
    public class ComponentsController: Controller
    {
        public ActionResult ExampleComponent()
        {
            var model = new ExampleComponentModel { Title = "Example Component title" };

            return this.View("~/Views/Feature/Example/ExampleComponent.cshtml", model);
        }
    }
}
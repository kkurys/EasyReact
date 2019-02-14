using Sitecore.Foundation.React.Mvc.Controllers;
using System.Web.Mvc;
using EasyReact.Feature.Example.Models;

namespace EasyReact.Feature.Example.Controllers
{
    public class ReactComponentsController : Controller
    {
        public ActionResult ExampleJsxComponent()
        {
            var model = new ExampleComponentModel { Title = "Example Jsx Component title" };

            return this.React("~/Views/Feature/Example/ExampleJsxComponent.jsx", model);
        }
    }
}
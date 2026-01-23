using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Cms.Core.Models;

namespace KnetCMS.Controllers
{
    public class HomePageController : RenderController
    {
        private readonly ILogger<RenderController> _logger;

        public HomePageController(
            ILogger<RenderController> logger,
            ICompositeViewEngine compositeViewEngine,
            IUmbracoContextAccessor umbracoContextAccessor)
            : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
            _logger = logger;
        }

        public override IActionResult Index()
        {
            _logger.LogInformation("HomePageController.Index() Hit!");
            return View("~/Views/HomePage.cshtml", CurrentPage);
        }

        public IActionResult HomePage(ContentModel model)
        {
            _logger.LogInformation("HomePageController.HomePage() Hit!");
            return View("~/Views/HomePage.cshtml", model.Content);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
namespace WebApplication1.Controllers.Lab4
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LanguageController: Controller
    {

        public void Index()
        {
            var lang = Language();
        }

    }

    public class LanguageController : ControllerBase
    {
        [HttpGet]

        public string GetLand()
        {
            var lang = new Polish();
            return lang.getLang();
        }

    }


}

using Microsoft.AspNetCore.Mvc;
using NewsApi.Models;

namespace NewsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : Controller
    {
        [HttpGet]
        public JsonResult Get()
        {
            var newsApiClient = new NewsApiClient();
            var result = newsApiClient.GetTopHeadlines(new TopHeadlinesRequest()
            {
                Language = Constants.Languages.EN,
                Country = Constants.Countries.US
            });
            return Json(result);
        }
    }
}

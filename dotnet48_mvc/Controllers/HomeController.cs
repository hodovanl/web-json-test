using System.Text.Json.Serialization;
using System.Web.Mvc;

namespace dotnet48_mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult JsonTest()
        {
            var res = new JsonResult
            {
                Data = new Entity1
                {
                    Field1 = "some value"
                }
            };
            res.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return res;
        }
    }

    public class Entity1
    {
        [JsonPropertyName("field1")]
        public string Field1 { get; set; }
    }
}
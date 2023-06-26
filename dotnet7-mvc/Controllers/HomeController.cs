using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace dotnet7_mvc.Controllers;

public class HomeController : Controller
{
    public IActionResult JsonTest()
    {
        return new JsonResult(new Entity1
        {
            Field1 = "some value"
        });
    }
}

public class Entity1
{
    [JsonPropertyName("field1")]
    public string Field1 { get; set; }
}
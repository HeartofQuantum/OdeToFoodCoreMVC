using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        //[Route("")]
        public string Phone()
        {
            return "1-405-627-5178";
        }
        //[Route("[action]")]
        public string Address()
        {
            return "USA";
        }
    }
}
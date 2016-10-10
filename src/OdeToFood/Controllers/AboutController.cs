using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "+1-555-555-5515";
        }

        public string Address()
        {
            return "1, Microsoft Way, Redmond, USA";
        }
    }
}

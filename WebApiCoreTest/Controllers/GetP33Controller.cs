using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCoreTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GetP33Controller : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "12334";
        }
        [HttpPost]
        [Route("[action]")]
        //https://localhost:7177/GetP33/Post111?id=1212121
        public string Post111(string id)
        {
            return id + "111";
        }
        [HttpPost]
        //https://localhost:7177/GetP33?id=1212121
        public string Post(string id)
        {
            return id;
        }
    }
}

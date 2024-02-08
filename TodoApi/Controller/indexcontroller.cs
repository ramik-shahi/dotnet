using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Model;

namespace TodoApi.Controller
{
   
    public class indexcontroller : ControllerBase
    {
        [HttpGet]
        [AllowAnonymous]
        [Route("/demo")]
        public ActionResult<string> Get()
        {
            var demoInstance = new TodoItem();
            demoInstance.main(null); // You might want to pass appropriate arguments

            return "Hello from DemoController!";
        }


    }
}

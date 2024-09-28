using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1N01712631.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1Controller : ControllerBase
    {
        ///<summary> Receives an HTTP GET request and returns a welcome message </summary>

        ///<returns> A string containing the message "Welcome to 5125!" </returns>

        /// <example> GET : http://localhost:xx/api/q1/welcome ----> "Welcome to 5125!" 
        /// </example>

        [HttpGet(template: "welcome")]
        public string welcome()
        {
            return "Welcome to 5125!";
        }

    }
}

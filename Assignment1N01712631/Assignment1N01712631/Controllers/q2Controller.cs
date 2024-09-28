using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1N01712631.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {
        ///<summary> Receives an HTTP GET request with one query parameter and returns a greeting message </summary>

        ///<returns> A string containing the greeting message with name </returns>

        ///<param name="name">The name to greeting </param>

        /// <emample> GET : http://localhost:xx/api/q2/greeting?name={name} 
        ///           GET : http://localhost:xx/api/q2/greeting?name=Gary ----> Hi Gary!
        /// </example>

        [HttpGet(template: "greeting")]
        public string greeting(string name)
        {
            return $"Hi {name}!";
        }
    }
}

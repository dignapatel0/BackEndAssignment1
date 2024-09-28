using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1N01712631.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
        ///<summary> Receives an HTTP POST request and returns message with secret integer </summary>

        ///<returns> Returns the given message with given {secret} integer </returns>

        /// <emample> POST  : http://localhost:xx/api/q5/secret
        /// 
        ///           REQUEST HEADERS: Content-Type: application/json
        ///           REQUEST BODY: 5
        ///           
        ///           -d"5" -H"Content-Type: application/json" http://localhost:xx/api/q5/secret ----> Shh..the secret is 5
        ///           -d"-200" -H"Content-Type: application/json" http://localhost:xx/api/q5/secret ----> Shh..the secret is -200
        /// </example>

        [HttpPost(template: "secret")]
        public string secret([FromBody] int secret)
        {
            return $"Shh..the secret is {secret}";
        }
    }
}

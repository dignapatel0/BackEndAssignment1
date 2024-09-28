using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1N01712631.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4Controller : ControllerBase
    {
        ///<summary> Receives an HTTP POST request and returns the start of a knock knock joke </summary>

        ///<returns> A string containing the first part of the joke </returns>

        /// <emample> POST : http://localhost:xx/api/q5/secret --> "Who's there?"
        ///           REQUEST HEADERS: (NONE)
        ///           REQUEST BODY: (NONE)
        /// </example>

        [HttpPost(template: "knockknock")]
        public string knockknock()
        {
            return "Who's there?";
        }
    }
}

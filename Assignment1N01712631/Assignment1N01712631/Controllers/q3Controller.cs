using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1N01712631.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {
        ///<summary> Receives an HTTP GET request and returns a cube of the provided integer base </summary>

        ///<returns> The integer result base * 3 </returns>

        /// <param name="base">The integer base to cube </param>

        /// <emample> GET :  http://localhost:xx/api/q3/cube/{base}
        ///           GET :  http://localhost:xx/api/q3/cube/4 ----> 64
        ///           GET :  http://localhost:xx/api/q3/cube/-4 ----> -64
        ///           GET :  http://localhost:xx/api/q3/cube/10 ----> 1000
        /// </example>
        
        [HttpGet(template: "cube/{Base}")]
        public int cube(int Base)
        {
            return (int)Math.Pow(Base, 3);
        }
    }
}

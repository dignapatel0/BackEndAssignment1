using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1N01712631.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        ///<summary> Receives an HTTP GET request and Calculates the area of a regular hexagon with a given side </summary>

        ///<returns> Returns the calculated area of a hexagon</returns> 

        /// <param name="side">The side length of the hexagon in double</param>

        /// <emample> GET :  http://localhost:xx/api/q3/cube/{base}
        ///           GET :  http://localhost:xx/api/q3/cube/4 ----> 64
        ///           GET :  http://localhost:xx/api/q3/cube/-4 ----> -64
        ///           GET :  http://localhost:xx/api/q3/cube/10 ----> 1000
        /// </example>

        [HttpGet(template: "hexagon")]
        public double hexagon(double side)
        {
            return (double)((double)(3 * Math.Sqrt(3) / 2 ) * Math.Pow(side, 2));
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2N01712631.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J1Controller : ControllerBase
    {

        /// Question-1 Problem J1: Deliv-e-droid

        /// <summary>
        /// Calculates the final score in the game based on number of Collisions and Deliveries.
        /// </summary>
        /// <returns>
        /// Returns the final score in the game.
        /// </returns>
        /// <param name="Collisions"> The number of times a collisions with an obstacle occurred</param>
        /// <param name="Deliveries"> The number of pacakges successfully delivered </param>
        /// <example> 
        /// POST : http://localhost:xx/api/J1/Delivedroid
        /// REQUEST HEADERS: Content-Type: application/x-www-form-urlencoded
        /// REQUEST BODY: Collisions=2&Deliveries=5
        /// -d"Collisions=2&Deliveries=5" -H"Content-Type: application/x-www-form-urlencoded" https://localhost:xx/api/J1/Delivedroid 
        /// Output -> 730
        /// </example> 

        [HttpPost(template: "Delivedroid")]
        public int Delivedroid([FromForm] int Collisions, [FromForm] int Deliveries)
        {
            int collisions_point = 10 * Collisions;
            int deliveries_point = 50 * Deliveries;
            int bonus_point = 500;
            int final_point;

            if (Deliveries > Collisions)
            {
                final_point = deliveries_point - collisions_point + bonus_point;
            }
            else
            {
                final_point = deliveries_point - collisions_point;
            }

            return final_point;
        }

        /// Question-2 2021 Problem J1: Boiling Water

        /// <summary> 
        /// Calculates atmospheric pressure based on the temperature at which water boils (B). 
        /// </summary> 
        /// <returns> 
        /// Returns the atmospheric pressure in kPa and sea level status (-1, 0, or 1). 
        /// </returns> 
        /// <param name="B">The temperature in °C at which water begins to boil.</param> 
        /// <example> 
        /// POST : http://localhost:xx/api/J1/BoilingWater
        /// REQUEST HEADERS: Content-Type: application/x-www-form-urlencoded
        /// REQUEST BODY: B=99
        /// -d"B=99" -H"Content-Type: application/x-www-form-urlencoded" https://localhost:xx/api/J1/BoilingWater 
        /// Output -> 95, 1
        /// </example> 

        [HttpPost(template: "BoilingWater")] 
        public String BoilingWater([FromForm] int B) 
        {
            int P = 5 * B - 400;
            int sea_level;

            if (P > 100)
            {
                sea_level = -1;
            }
            else if (P == 100)
            {
                sea_level = 0;
            }
            else
            {
                sea_level = 1;
            }
            return $"{P}\n{sea_level}";
        }

    }
}

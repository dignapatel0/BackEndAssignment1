using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2N01712631.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J2Controller : ControllerBase
    {

        /// Question-3 Problem J2: Chili Peppers

        /// <summary>
        /// Calculates the total spiciness of Ron's chili based on the peppers added.
        /// </summary>
        /// <returns>
        /// Returns the total spiciness of the chili.
        /// </returns>
        /// <param name="Ingredients">A comma-separated list of pepper names added to the chili.</param>
        /// <example> 
        /// GET: https://localhost:xx/api/J2/ChiliPeppers?Ingredients=Poblano,Cayenne,Thai,Poblano
        /// Poblano = 1500 SHU 
        /// Cayenne = 40000 SHU 
        /// Thai = 75000 SHU 
        /// Poblano = 1500 SHU 
        /// Total = 1500 + 40000 + 75000 + 1500 = 118000 SHU
        /// Output -> 118000
        /// </example>

        [HttpGet(template: "ChiliPeppers")]
        public int ChiliPeppers(string Ingredients)
        {
            int Poblano = 1500;
            int Mirasol = 6000;
            int Serrano = 15500;
            int Cayenne = 40000;
            int Thai = 75000;
            int Habanero = 125000;

            int spiciness_total = 0;
            string[] list_peppers = Ingredients.Split(',');

            foreach (string pepper in list_peppers)
            {
                string trim_pepper = pepper.Trim();

                if (trim_pepper == "Poblano")
                {
                    spiciness_total += Poblano;
                }
                else if (trim_pepper == "Mirasol")
                {
                    spiciness_total += Mirasol;
                }
                else if (trim_pepper == "Serrano")
                {
                    spiciness_total += Serrano;
                }
                else if (trim_pepper == "Cayenne")
                {
                    spiciness_total += Cayenne;
                }
                else if (trim_pepper == "Thai")
                {
                    spiciness_total += Thai;
                }
                else
                {
                    spiciness_total += Habanero;
                }
            }

            return spiciness_total;
        }

        /// Question-4 2017 Problem J2: Shifty Sum

        /// <summary> 
        /// Calculates the shifty sum of a number after shifting it a specified number of times. 
        /// </summary> 
        /// <returns>
        /// Returns the total shifty sum.
        /// </returns>
        /// <param name="number">The starting number to calculate the shifty sum from.</param> 
        /// <param name="shifts">The number of times to shift the number.</param>
        /// <example> 
        /// POST: https://localhost:xx/api/J2/Calculate
        /// REQUEST HEADERS: Content-Type: application/x-www-form-urlencoded
        /// REQUEST BODY: number=12&shifts=3 
        /// -d"number=12&shifts=3" -H"Content-Type: application/x-www-form-urlencoded" https://localhost:xx/api/J2/Calculate 
        /// Output -> 13332
        /// </example> 

        [HttpPost(template: "Calculate")]
        public int Calculate([FromForm] int number, [FromForm] int shifts)
        {
            int totalSum = 0;
            int currentNumber = number;
            for (int i = 0; i <= shifts; i++)
            {
                totalSum += currentNumber;
                currentNumber *= 10;
            }
            return totalSum;
        }

    }
}

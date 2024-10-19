using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2N01712631.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J3Controller : ControllerBase
    {
        /// Question-3 2021 Problem J3: Secret Instructions

        /// <summary>
        /// Decodes the secret instructions based on the provided five-digit codes.
        /// </summary>
        /// <returns>
        /// A list of decoded instructions containing the direction and number of steps.
        /// </returns>
        /// <param name="sequences">A list of decoded codes.</param>
        /// <example>
        /// POST: "https://localhost:xx/api/J3/code?sequences=57234&sequences=00907&sequences=34100&sequences=99999" 
        /// REQUEST BODY: ["57234", "00907", "34100", "99999"]
        /// Output -> right 234, right 907, left 100
        /// </example>

        [HttpGet(template: "code")]
        public string code([FromQuery] List<string> sequences)
        {
            string result = "";
            string preDirection = "";

            foreach (var num in sequences)
            {
                if (num == "99999")
                {
                    break;
                }

                if (num.Length != 5)
                {
                    result += "Each instruction must be exactly five digits.\n";
                    continue;
                }

                int firstDigit = int.Parse(num.Substring(0, 1));
                int secondDigit = int.Parse(num.Substring(1, 1));
                int sum = firstDigit + secondDigit;

                string steps = num.Substring(2);
                string direction = "";

                if (sum == 0)
                {
                    direction = preDirection;
                }
                else if ((sum % 2) != 0)
                {
                    direction = "left";
                }
                else
                {
                    direction = "right";
                }

                result += $"{direction} {steps}\n";
                preDirection = direction;
            }

            return result;
        }

    }
}

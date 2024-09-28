using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1N01712631.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q7Controller : ControllerBase
    {
        ///<summary> Receives an HTTP GET request and returns a current date in yyyy-MM-dd format, adjusted by {days}</summary>

        ///<returns> Returns a string containing the adjusted date in yyyy-MM-dd format</returns> 

        /// <param name="days">The number of days to adjust the date</param>

        /// <emample> GET :  http://localhost:xx/api/q7/timemachine?days={days}
        ///                  Today date = 2024-09-27
        ///           GET :  http://localhost:xx/api/q7/timemachine?days=1 ----> 2024-09-28
        ///           GET :  http://localhost:xx/api/q7/timemachine?days=-1 ----> 2024-09-26
        /// </example>
        
        [HttpGet(template: "timemachine")]
        public string timemachine(double days)
        {
            //Today date
            DateTime todaydate = DateTime.Today;

            DateTime ansdate = todaydate.AddDays(days);
            return ansdate.ToString("yyyy-MM-dd");
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Encodings.Web;
using Microsoft.Extensions.Hosting;

namespace Assignment1N01712631.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q8Controller : ControllerBase
    {
        [HttpPost(template: "Squashfellows")]
        public string squashfellows([FromForm] int small, [FromForm] int large)
        {
            ///<summary> Receives an HTTP POST request and 
            ///          calculates the checkout summary for an order of SquashFellows plushies 
            ///          and returns a total amount of order
            ///</summary>

            ///<returns> Returns a total amount of order with 13% HST summary.</</returns> 

            /// <param name="small">The number of small SquashFellows</param>
            /// <param name="large">The number of large SquashFellows</param>

            /// <emample> POST  : http://localhost:xx/api/q8/squashfellows
            /// 
            ///           REQUEST HEADERS: Content-Type:application / x - www - form - urlencoded
            ///           REQUEST BODY: Small=1&Large=1
            ///
            ///           -d"1" -H"Content-Type:application / x - www - form - urlencoded" 
            ///           http://localhost:xx/api/q8/squashfellows ----> 1 Small @ $25.50 = $25.50; 
            ///           1 Large @ $40.50 = $40.50; Subtotal = $66.00; Tax = $8.58 HST; Total = $74.58
             /// </example>

            double smalltotal = small * 25.50;
            double largetotal = large * 40.50;
            double subtotal = smalltotal + largetotal;
            double tax = Math.Round(subtotal * 0.13, 2);
            double totaltax = subtotal + tax;

            var cinfo = new CultureInfo("en-CA");

            string smalltotalprint = smalltotal.ToString("C2", cinfo);
            string largetotalprint = largetotal.ToString("C2", cinfo);
            string subtotalprint = subtotal.ToString("C2", cinfo);
            string taxprint = tax.ToString("C2", cinfo);
            string taxtotalprint = totaltax.ToString("C2", cinfo);

            return $" {small} Small @ $25.50 = {smalltotalprint}; {large} Large @ $40.50 = {largetotalprint}; Subtotal = {subtotalprint}; Tax = {taxprint} HST; Total = {taxtotalprint}";
        }
    }
}

using SivachevWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SivachevWEB.Controllers.api
{
    public class CalculatorController : ApiController
    {
        [HttpPost]

        public CalculatorResponse Calculate

                    (CalculatorRequest request)

        {

            decimal result;



            switch (request.Action)

            {

                case "+":

                    result = request.DigA + request.DigB;

                    break;

                case "-":

                    result = request.DigA - request.DigB;

                    break;

                case "*":

                    result = request.DigA * request.DigB;

                    break;

                case "/":

                    result = request.DigA / request.DigB;

                    break;

                default:

                    throw new InvalidOperationException();

            }



            return new CalculatorResponse { Result = result };

        }
    }
}

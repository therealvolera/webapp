using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SivachevWEB.Models
{
    public class CalculatorRequest
    {
        public decimal DigA { get; set; }
        public decimal DigB { get; set; }
        public string Action { get; set; }
    }
}
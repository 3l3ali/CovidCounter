using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CovidCounter.Models
{
    public class Global
    {
        public int NewConfirmed { get; set; } 
        public int TotalConfirmed { get; set; } 
        public int NewDeaths { get; set; } 
        public int TotalDeaths { get; set; } 
        public int NewRecovered { get; set; } 
        public int TotalRecovered { get; set; } 
    }
}
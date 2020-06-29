using System;
using System.Collections.Generic;

namespace CovidCounter.Models
{
    public class CovidModel
    {
        public Global Global { get; set; }
        public List<SingleCountry> Countries { get; set; } 
        public DateTime Date { get; set; } 
    }


    
}
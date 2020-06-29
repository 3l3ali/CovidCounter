using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CovidCounter.Models;
using HtmlAgilityPack;
using ScrapySharp.Network;
using ScrapySharp.Extensions;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CovidCounter.Controllers
{
    public class HomeController : Controller
    {
        static private string url = "https://api.covid19api.com/summary";
        private readonly IHttpClientFactory _factory;
        public HomeController(IHttpClientFactory factory)
        {
            _factory = factory;
        }

        public async Task<IActionResult> Index()
        {
            CovidModel covid;

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            var client = _factory.CreateClient();

            HttpResponseMessage response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                covid = await response.Content.ReadFromJsonAsync<CovidModel>();
                var countriesList = new SelectList(covid.Countries.ToDictionary(c => c.Country, c => c.Country), "Key", "Value");
                ViewBag.countriesList = countriesList;
                covid.Countries.Sort((a,b) => b.TotalConfirmed.CompareTo(a.TotalConfirmed));
            }
            else
            {
                covid = null;
            }
            
            return View(covid);
        }

    }
}

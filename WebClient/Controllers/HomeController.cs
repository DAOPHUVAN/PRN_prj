using DataLayer.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebApi.DTOs;
using WebClient.Models;

namespace WebClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int? id)
        {

            List<BookDTO> books = new List<BookDTO>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44310/api/");
                var reponseTask = client.GetAsync("Books/" + id);
                reponseTask.Wait();

                var result = reponseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    string json_data = JsonConvert.SerializeObject(readTask.Result); 
                    var book = JsonConvert.DeserializeObject(json_data).ToString();
                    var resultBook = JsonConvert.DeserializeObject<BookDTO>(book);
                    books.Add(resultBook);
                }
            }
            ViewBag.Book = books;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}

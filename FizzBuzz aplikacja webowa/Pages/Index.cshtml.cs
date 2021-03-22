using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz_aplikacja_webowa.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace FizzBuzz_aplikacja_webowa.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;



        [BindProperty]
        public Class Class { get; set; }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Class.Liczba % 3 == 0)
                      {Class.Wynik += "FIZZ"; }
                if (Class.Liczba % 5 == 0)
                      { Class.Wynik += "BUZZ"; }
                if (Class.Wynik == null)
                      {Class.Wynik = String.Format("Liczba: "+Class.Liczba+" nie spełnia kryteriów Fizz/Buzz.");}
                HttpContext.Session.SetString("SessionClass",
                JsonConvert.SerializeObject(Class));
            }  
        }
    }

}

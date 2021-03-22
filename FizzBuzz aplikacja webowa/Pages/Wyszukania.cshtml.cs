using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FizzBuzz_aplikacja_webowa.Models;

namespace FizzBuzz_aplikacja_webowa.Pages
{
    public class ClassModel : PageModel
    {
        public Class Class { get; set; }

        public void OnGet()
        {
            var SessionClass =
            HttpContext.Session.GetString("SessionClass");
            if (SessionClass != null)
                Class =
                JsonConvert.DeserializeObject<Class>(SessionClass);
        }
    }
}
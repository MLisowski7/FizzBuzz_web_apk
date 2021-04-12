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
using FizzBuzz_aplikacja_webowa.Data;

namespace FizzBuzz_aplikacja_webowa.Pages
{
    public class IndexModel : PageModel
    {
        private readonly LiczbaContext _context;

        private readonly ILogger<IndexModel> _logger;



        [BindProperty]
        public Class Class { get; set; }


        public IndexModel(ILogger<IndexModel> logger, LiczbaContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
          
        }

        public void OnPost() { 
               if (ModelState.IsValid)
            {
                Class.FizzBuzz(Class.Liczba);

                _context.Class.Add(Class);

                if(_context.Class.Count()>=10)
                {
                    _context.Remove(_context.Class.First());
                }

                _context.SaveChanges();
                HttpContext.Session.SetString("SessionClass",
                JsonConvert.SerializeObject(Class));
             }
            }  
        }
    }



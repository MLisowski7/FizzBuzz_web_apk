using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FizzBuzz_aplikacja_webowa.Data;
using FizzBuzz_aplikacja_webowa.Models;


namespace FizzBuzz_aplikacja_webowa.Pages
{
    public class ClassModel : PageModel
    {
        private readonly LiczbaContext _context;
        public ClassModel(LiczbaContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Class Class { get; set; }
        public IEnumerable<Class> Wyszukania { get; set; }
        public void OnGet()
        {
            Wyszukania = _context.Class.ToList();
        }
        public IActionResult OnPostDelete(int Id)
        {
            var usun = _context.Class.Find(Id);
            if(usun != null)
            {
                _context.Remove(usun);
                _context.SaveChanges();
                return RedirectToPage("Wyszukania");
            }
            else
            {
                return NotFound();
            }
        }
    }
}
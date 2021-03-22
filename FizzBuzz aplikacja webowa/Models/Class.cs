using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzz_aplikacja_webowa.Models
{
    public class Class
    {
        [Display(Name = "Liczba do sprawdzenia:")]
        [Required(ErrorMessage = "Pole Liczba jest obowiazkowe."), Range(1, 1000, ErrorMessage = "Wprowadzona liczba musi znajdowac sie w przedziale od 1 do 1000.")]
        public int Liczba { get; set; }
        public string Wynik { get; set; }

         
    }
}

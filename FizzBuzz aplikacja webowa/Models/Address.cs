using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzz_aplikacja_webowa.Models
{
    public class Address
    {
        [Display(Name = "Liczba do sprawdzenia:")]
        [Required(ErrorMessage = "Pole Liczba jest obowiazkowe."), Range(1, 1000, ErrorMessage = "Wartość pola musi znajdowac sie w przedziale od 1 do 1000.")]
        public string Number { get; set; }

        public string Result { get; set; }


    }
}

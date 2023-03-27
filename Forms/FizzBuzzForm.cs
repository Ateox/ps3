using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Forms
{
    public class FizzBuzzForm
    {
        public string Information { get; set; }

        [Display(Name = "Twoje imię: ")]
        [Required(ErrorMessage = "Pole jest obowiązkowe"), MaxLength(100)]
        public string Name { get; set; }
        [Display(Name = "Twój rok urodzenia")]
        [Required(ErrorMessage = "Pole jest obowiązkowe"), Range(1899, 2022, ErrorMessage = "Oczekiwana wartość {0} z zakredu {1} i {2}.")]
        public int? Year { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace DSR_KAZAR_N1.Models
{
    public class page1Model
    {
        [Required(ErrorMessage = "polje Ime mora biti izpolnjeno")]
        [Display(Name = "Ime")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Ime lahko vsebuje samo črke.")]
        public string name { get; set; }

        [Required(ErrorMessage = "polje Priimek mora biti izpolnjeno")]
        public string surname { get; set; }

        [Required(ErrorMessage = "polje Datum Rojstva mora biti izpolnjeno")]
        public DateTime birthdate { get; set; }

        [Required(ErrorMessage = "polje EMŠO mora biti izpolnjeno")]
        public string emso { get; set; }

        public page1Model(string name, string surname, DateTime birthdate, string emso)
        {
            this.name = name;
            this.surname = surname;
            this.birthdate = birthdate;
            this.emso = emso;
        }

        public page1Model()
        {
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace DSR_KAZAR_N1.Models
{
    public class page1Model
    {
        [Required(ErrorMessage = "polje Ime mora biti izpolnjeno")]
        [Display(Name = "Ime")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Ime nesme vsebovati števil.")]
        public string name { get; set; }

        [Required(ErrorMessage = "polje Priimek mora biti izpolnjeno")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Priimek nesme vsebovati števil.")]
        public string surname { get; set; }

        [Required(ErrorMessage = "polje Datum Rojstva mora biti izpolnjeno")]
        [DateRange]
        public DateTime birthdate { get; set; }

        [Required(ErrorMessage = "polje KrajRojstva Rojstva mora biti izpolnjeno")]
        public string birthplace { get; set; }

        [Required(ErrorMessage = "Polje EMŠO mora biti izpolnjeno")]
        [EmsoValidation]
        public string emso { get; set; }

        public page1Model(string name, string surname, DateTime birthdate,string birthplace, string emso)
        {
            this.name = name;
            this.surname = surname;
            this.birthdate = birthdate;
            this.birthplace = birthplace;
            this.emso = emso;
        }
        public page1Model()
        {
        }
    }
}

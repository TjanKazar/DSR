using DSR_KAZAR_N1.Models;
using System.ComponentModel.DataAnnotations;

namespace DSR_KAZAR_N1.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "polje Uporabniško Ime mora biti izpolnjeno")]
        public string Name { get; set; }
        [Required(ErrorMessage = "polje Geslo mora biti izpolnjeno")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


    }
}

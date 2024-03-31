using System.ComponentModel.DataAnnotations;

namespace DSR_KAZAR_N1.Models
{
    public class page3Model
    {
        [Required(ErrorMessage = "polje Email mora biti izpolnjeno")]
        public string email { get; set; }

        [Required(ErrorMessage = "polje Geslo mora biti izpolnjeno")]
        public string password { get; set; }

        [Required(ErrorMessage = "polje Geslo mora biti izpolnjeno")]
        [Compare("password", ErrorMessage = "Gesli se ne ujemata")]
        public string password2 { get; set; }

        public page3Model(string email, string password, string password2)
        {
            this.email = email;
            this.password = password;
            this.password2 = password2;
        }

        public page3Model()
        {
        }
    }
}

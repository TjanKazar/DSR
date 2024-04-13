using System.ComponentModel.DataAnnotations;
namespace DSR_KAZAR_N1.Models
{
    public class UporabnikZGesli : UporabnikModel
    {
        [Required(ErrorMessage = "polje Geslo mora biti izpolnjeno")]
        public string password { get; set; }

        [Required(ErrorMessage = "polje Geslo mora biti izpolnjeno")]
        [Compare("password", ErrorMessage = "Gesli se ne ujemata")]
        public string password2 { get; set; }

        public UporabnikZGesli(string name, string surname, DateTime birthdate, string birthplace, string emso, string address, string post, int postnum, string country, string email, string password, string password2)
            : base(name, surname, birthdate, birthplace, emso, address, post, postnum, country, email)
        {
            this.password = password;
            this.password2 = password2;
        }

        public UporabnikZGesli()
        {
        }
    }
}

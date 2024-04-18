using DSR_KAZAR_N1.dbContexts;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DSR_KAZAR_N1.Models
{
    public class UporabnikZGesli : IdentityUser
    {
        

        public int UporabnikModelId { get; set; }

        [ForeignKey("UporabnikModelId")]
        public UporabnikModel uporabnik {get; set;}

        [Required(ErrorMessage = "polje Geslo mora biti izpolnjeno")]
        public string password { get; set; }

        [Required(ErrorMessage = "polje Geslo mora biti izpolnjeno")]
        [Compare("password", ErrorMessage = "Gesli se ne ujemata")]
        public string password2 { get; set; }

        public UporabnikZGesli(string name, string surname, DateTime birthdate, string birthplace, string emso, string address, string post, int postnum, string country, string email, string password, string password2)
        {
            uporabnik = new UporabnikModel(name, surname, birthdate, birthplace, emso, address, post, postnum, country, email);
            this.password = password;
            this.password2 = password2;
        }

        public UporabnikZGesli(UporabnikModel uporabnik, string password, string password2)
        {
            this.uporabnik = uporabnik;
            this.password = password;
            this.password2 = password2;
        }

        public UporabnikZGesli(int uporabnikModelId, string password, string password2)
        {
            UporabnikModelId = uporabnikModelId;
            this.password = password;
            this.password2 = password2;
        }

        public UporabnikZGesli()
        {
        }
    }
}

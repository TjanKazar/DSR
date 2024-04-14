using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DSR_KAZAR_N1.Models
{
    public class UporabnikZGesli
    {
        [Key]
        public int Id { get; set; }

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
            uporabnik.name = name;
            uporabnik.surname = surname;
            uporabnik.birthdate = birthdate;
            uporabnik.birthplace = birthplace;
            uporabnik.emso = emso;
            uporabnik.address = address;
            uporabnik.post = post;
            uporabnik.postnum = postnum;
            uporabnik.country = country;
            uporabnik.email = email;
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

using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace DSR_KAZAR_N1.Models
{
    public class UporabnikModel
    {
        [Required(ErrorMessage ="polje Ime mora biti izpolnjeno")]
        public string name { get; set; }

        [Required(ErrorMessage = "polje Priimek mora biti izpolnjeno")]
        public string surname{ get; set; }

        [Required(ErrorMessage = "polje Datum Rojstva mora biti izpolnjeno")]
        public DateTime birthdate { get; set; }

        [Required(ErrorMessage = "polje EMŠO mora biti izpolnjeno")]
        public string emso { get; set; }

        [Required(ErrorMessage = "polje Naslov mora biti izpolnjeno")]
        public string address { get; set; }

        [Required(ErrorMessage = "polje Pošta mora biti izpolnjeno")]
        public string post {  get; set; }

        [Required(ErrorMessage = "polje Poštna številka mora biti izpolnjeno")]
        public int postnum { get; set; }

        [Required(ErrorMessage = "polje Država mora biti izpolnjeno")]
        public string country { get; set; }

        [Required(ErrorMessage = "polje Email mora biti izpolnjeno")]
        public string email { get; set; }

        [Required(ErrorMessage = "polje Geslo mora biti izpolnjeno")]
        public string password { get; set; }

        [Required(ErrorMessage = "polje Geslo mora biti izpolnjeno")]
        [Compare("password", ErrorMessage = "Gesli se ne ujemata")]
        public string password2 { get; set; }

        public List<Racun> receipts { get; set; }

        public UporabnikModel(string name, string surname, DateTime birthdate, string email, List<Racun> receipts)
        {
            this.name = name;
            this.surname = surname;
            this.birthdate = birthdate;
            this.email = email;
            this.receipts = receipts;
        }

        public UporabnikModel(string name, string surname, DateTime birthdate, string emso, string address, string email, string password, List<Racun> receipts)
        {
            this.name = name;
            this.surname = surname;
            this.birthdate = birthdate;
            this.emso = emso;
            this.address = address;
            this.email = email;
            this.password = password;
            this.receipts = receipts;
        }
        public UporabnikModel(string name, string surname, DateTime birthdate, string emso, string address, string email,string post,int postnum,string country, string password) {
            this.name = name;
            this.surname = surname;
            this.birthdate = birthdate;
            this.emso = emso;
            this.address = address;
            this.email = email;
            this.post = post;
            this.postnum = postnum;
            this.country = country;
            this.password = password;
        }

        public UporabnikModel(string name, string surname, DateTime birthdate, string emso)
        {
            this.name = name;
            this.surname = surname;
            this.birthdate = birthdate;
            this.emso = emso;
        }
    }
}

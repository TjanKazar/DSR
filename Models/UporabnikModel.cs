using System.ComponentModel.DataAnnotations;

namespace DSR_KAZAR_N1.Models
{
    public class UporabnikModel
    {
        [Required(ErrorMessage ="polje Ime mora biti izpolnjeno")]
        [Display(Name="Ime")]
        public string name { get; set; }
        [Required]
        [Display(Name ="Priimek")]
        public string surname{ get; set; }
        [Required]
        public DateTime birthdate { get; set; }
        [Required]
        public string emso { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string post {  get; set; }
        [Required]
        public int postnum { get; set; }
        [Required]
        public string country { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string password2 { get; set; }
        [Required]
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
        public UporabnikModel()
        {

        }
    }
}

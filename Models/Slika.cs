using System.ComponentModel.DataAnnotations;

namespace DSR_KAZAR_N1.Models
{
    public class Slika
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ime { get; set; }
        [Required]
        public double cena { get; set; }
        [Required]
        public int letoIzdaje { get; set; }
        [Required]
        public bool jeUnikat { get; set; }

        public Racun? racun { get; set; }
        public Slika(string ime, double cena, int letoIzdaje, bool jeUnikat)
        {
            this.ime = ime;
            this.cena = cena;
            this.letoIzdaje = letoIzdaje;
            this.jeUnikat = jeUnikat;
        }
        public Slika(string ime, double cena, int letoIzdaje, bool jeUnikat, Racun racun)
        {
            this.ime = ime;
            this.cena = cena;
            this.letoIzdaje = letoIzdaje;
            this.jeUnikat = jeUnikat;
            this.racun = racun;
        }

        public Slika()
        {
        }
    }
}

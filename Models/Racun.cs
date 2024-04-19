using System.ComponentModel.DataAnnotations;
using System.Security.Authentication.ExtendedProtection;

namespace DSR_KAZAR_N1.Models
{
    public class Racun
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime datumIzdaje { get; set; }
        [Required]
        public double cenaSkupaj { get; set; }

        // public int SlikaId
        // public int UporabnikId

		public Racun(DateTime datumIzdaje, double cenaSkupaj)
		{
			this.datumIzdaje = datumIzdaje;
			this.cenaSkupaj = cenaSkupaj;
		}

		public Racun() { }
    }
}

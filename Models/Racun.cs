using System.Security.Authentication.ExtendedProtection;

namespace DSR_KAZAR_N1.Models
{
    public class Racun
    {
        public DateTime datumIzdaje { get; set; }
        public List<Slika> nakup { get; set; }
        public double cenaSkupaj { get; set; }

        public Racun(DateTime letoIzdaje, List<Slika> nakup, double cenaSkupaj)
        {
            datumIzdaje = letoIzdaje;
            this.nakup = nakup;
            this.cenaSkupaj = cenaSkupaj;
        }

		public Racun(DateTime datumIzdaje, double cenaSkupaj)
		{
			this.datumIzdaje = datumIzdaje;
			this.cenaSkupaj = cenaSkupaj;
		}

		public Racun() { }
    }
}

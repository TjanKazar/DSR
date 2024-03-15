using System.Security.Authentication.ExtendedProtection;

namespace DSR_KAZAR_N1
{
    public class Racun
    {
        public DateTime datumIzdaje { get; set; }
        public List<Slika> nakup { get; set; }
        public decimal cenaSkupaj{ get; set; }

        public Racun(DateTime letoIzdaje, List<Slika> nakup, decimal cenaSkupaj)
        {
            this.datumIzdaje = letoIzdaje;
            this.nakup = nakup;
            this.cenaSkupaj = cenaSkupaj;
        }
    }
}

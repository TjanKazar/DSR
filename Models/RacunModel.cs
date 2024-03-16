using System.Security.Authentication.ExtendedProtection;

namespace DSR_KAZAR_N1.Models
{
    public class Racun
    {
        public DateTime datumIzdaje { get; set; }
        public List<SlikaModel> nakup { get; set; }
        public decimal cenaSkupaj { get; set; }

        public Racun(DateTime letoIzdaje, List<SlikaModel> nakup, decimal cenaSkupaj)
        {
            datumIzdaje = letoIzdaje;
            this.nakup = nakup;
            this.cenaSkupaj = cenaSkupaj;
        }
    }
}

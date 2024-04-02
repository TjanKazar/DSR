namespace DSR_KAZAR_N1.Models
{
    public class SlikaModel
    {
        public int id { get; set; }
        public string ime { get; set; }
        public decimal cena { get; set; }
        public int letoIzdaje { get; set; }
        public bool jeUnikat { get; set; }
        public Racun? racun { get; set; }
        public SlikaModel(string ime, decimal cena, int letoIzdaje, bool jeUnikat)
        {
            this.ime = ime;
            this.cena = cena;
            this.letoIzdaje = letoIzdaje;
            this.jeUnikat = jeUnikat;
        }
        public SlikaModel(string ime, decimal cena, int letoIzdaje, bool jeUnikat, Racun racun)
        {
            this.ime = ime;
            this.cena = cena;
            this.letoIzdaje = letoIzdaje;
            this.jeUnikat = jeUnikat;
            this.racun = racun;
        }

        public SlikaModel()
        {
        }
    }
}

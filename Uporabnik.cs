namespace DSR_KAZAR_N1
{
    public class Uporabnik
    {
        public string ime { get; set; }
        public string priimek { get; set; }
        public DateTime datumRojstva { get; set; }
        public string kontakt { get; set; }
        public List<Racun> racuni { get; set; }

        public Uporabnik(string ime, string priimek, DateTime datumRojstva, string kontakt, List<Racun> racuni)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.datumRojstva = datumRojstva;
            this.kontakt = kontakt;
            this.racuni = racuni;
        }
    }
}

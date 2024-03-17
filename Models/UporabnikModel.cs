namespace DSR_KAZAR_N1.Models
{
    public class UporabnikModel
    {
        public string ime { get; set; }
        public string priimek { get; set; }
        public DateTime datumRojstva { get; set; }
        public string emšo { get; set; }
        public string naslov { get; set; }
        public string email { get; set; }
        public string geslo { get; set; }
        public List<Racun> racuni { get; set; }

        public UporabnikModel(string ime, string priimek, DateTime datumRojstva, string email, List<Racun> racuni)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.datumRojstva = datumRojstva;
            this.email = email;
            this.racuni = racuni;
        }

        public UporabnikModel(string ime, string priimek, DateTime datumRojstva, string emšo, string naslov, string email, string geslo, List<Racun> racuni)
        {
            this.ime = ime;
            this.priimek = priimek;
            this.datumRojstva = datumRojstva;
            this.emšo = emšo;
            this.naslov = naslov;
            this.email = email;
            this.geslo = geslo;
            this.racuni = racuni;
        }
        public UporabnikModel(){}
    }
}

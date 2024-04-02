namespace DSR_KAZAR_N1.Models
{
    public class homeModel
    {
        public SlikaModel Slika { get; set; }
        public UporabnikModel Uporabnik { get; set; }
        public Racun Racun {get; set;}

        public homeModel(SlikaModel slika, UporabnikModel uporabnik, Racun racun)
        {
            Slika = slika;
            Uporabnik = uporabnik;
            Racun = racun;
        }

        public homeModel()
        {
        }
    }
}

namespace DSR_KAZAR_N1.Models
{
    public class homeModel
    {
        public Slika Slika { get; set; }
        public UporabnikModel Uporabnik { get; set; }
        public Racun Racun {get; set;}

        public homeModel(Slika slika, UporabnikModel uporabnik, Racun racun)
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

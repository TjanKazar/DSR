namespace DSR_KAZAR_N1.Models
{
    public class lokacije
    {
        public int Id { get; set; }
        public string lokacija { get; set; }

        public lokacije(int id, string lokacija)
        {
            Id = id;
            this.lokacija = lokacija;
        }
        public static List<lokacije> GetLokacije()
        {
            var Lokacije = new List<lokacije>
            {
                new lokacije(1, "Ljubljana"),
                new lokacije(2, "Maribor"),
                new lokacije(3, "Murska Sobota"),
                new lokacije(4, "Celje"),
                new lokacije(5, "Portorož"),
                new lokacije(6, "New York")
            };

            return Lokacije;
        }
    }
    
    
}

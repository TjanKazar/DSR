namespace DSR_KAZAR_N1.Models
{
	public class Uporabnik
	{
		public string name { get; set; }
		public string surname { get; set; }
		public DateTime birthdate { get; set; }
		public string email { get; set; }
		public List<Racun> receipts { get; set; }

		
		public Uporabnik(string name, string surname, DateTime birthdate, string email)
		{
			this.name = name;
			this.surname = surname;
			this.birthdate = birthdate;
			this.email = email;
		}

        public Uporabnik()
        {
        }
    }
}

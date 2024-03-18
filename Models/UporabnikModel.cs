namespace DSR_KAZAR_N1.Models
{
    public class UporabnikModel
    {
        public string name { get; set; }
        public string surname{ get; set; }
        public DateTime birthdate { get; set; }
        public string emso { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public List<Racun> receipts { get; set; }

        public UporabnikModel(string name, string surname, DateTime birthdate, string email, List<Racun> receipts)
        {
            this.name = name;
            this.surname = surname;
            this.birthdate = birthdate;
            this.email = email;
            this.receipts = receipts;
        }

        public UporabnikModel(string name, string surname, DateTime birthdate, string emso, string address, string email, string password, List<Racun> receipts)
        {
            this.name = name;
            this.surname = surname;
            this.birthdate = birthdate;
            this.emso = emso;
            this.address = address;
            this.email = email;
            this.password = password;
            this.receipts = receipts;
        }
        public UporabnikModel(){}
    }
}

using System.ComponentModel.DataAnnotations;

namespace DSR_KAZAR_N1.Models
{
    public class page2Model
    {
        [Required(ErrorMessage = "polje Naslov mora biti izpolnjeno")]
        public string address { get; set; }

        [Required(ErrorMessage = "polje Pošta mora biti izpolnjeno")]
        public string post { get; set; }

        [Required(ErrorMessage = "polje Poštna številka mora biti izpolnjeno")]
        public int postnum { get; set; }

        [Required(ErrorMessage = "polje Država mora biti izpolnjeno")]
        public string country { get; set; }

        public page2Model(string address, string post, int postnum, string country)
        {
            this.address = address;
            this.post = post;
            this.postnum = postnum;
            this.country = country;
        }

        public page2Model()
        {
        }
    }
}

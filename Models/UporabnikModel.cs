using System;
using System.ComponentModel.DataAnnotations;

public class UporabnikModel
{
    [Required(ErrorMessage = "polje Ime mora biti izpolnjeno")]
    [Display(Name = "Ime")]
    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Ime nesme vsebovati števil.")]
    public string name { get; set; }

    [Required(ErrorMessage = "polje Priimek mora biti izpolnjeno")]
    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Priimek nesme vsebovati števil.")]
    public string surname { get; set; }

    [Required(ErrorMessage = "polje Datum Rojstva mora biti izpolnjeno")]
    [DateRange]
    public DateTime birthdate { get; set; }

    [Required(ErrorMessage = "polje Kraj Rojstva Rojstva mora biti izpolnjeno")]
    [KrajRojstvaValidation]
    public string birthplace { get; set; }

    [Required(ErrorMessage = "Polje EMŠO mora biti izpolnjeno")]
    [EmsoValidation]
    public string emso { get; set; }

    [Required(ErrorMessage = "polje Naslov mora biti izpolnjeno")]
    public string address { get; set; }

    [Required(ErrorMessage = "polje Pošta mora biti izpolnjeno")]
    public string post { get; set; }

    [Required(ErrorMessage = "polje Poštna številka mora biti izpolnjeno")]
    public int postnum { get; set; }

    [Required(ErrorMessage = "polje Država mora biti izpolnjeno")]
    public string country { get; set; }

    [Required(ErrorMessage = "polje Email mora biti izpolnjeno")]
    [EmailAddress(ErrorMessage = "Polje email mora biti e-poštni naslov")]
    public string email { get; set; }

    public UporabnikModel()
    {
    }

    public UporabnikModel(string name, string surname, DateTime birthdate, string email)
    {
        this.name = name;
        this.surname = surname;
        this.birthdate = birthdate;
        this.email = email;
    }

    public UporabnikModel(string name, string surname, DateTime birthdate, string birthplace, string emso, string address, string post, int postnum, string country, string email)
    {
        this.name = name;
        this.surname = surname;
        this.birthdate = birthdate;
        this.birthplace = birthplace;
        this.emso = emso;
        this.address = address;
        this.post = post;
        this.postnum = postnum;
        this.country = country;
        this.email = email;
    }
}

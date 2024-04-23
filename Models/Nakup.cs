using DSR_KAZAR_N1.Models;
using System.ComponentModel.DataAnnotations;

public class Nakup
{
	[Key]
	public int Id { get; set; }
	public Slika slika { get; set; }
	public UporabnikZGesli uporabnik { get; set; }

	public Nakup() { }

	public Nakup(Slika slika, UporabnikZGesli uporabnik)
	{
		this.slika = slika;
		this.uporabnik = uporabnik;
	}
}


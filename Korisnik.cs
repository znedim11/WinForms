using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    [Table("Korisnik")]
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        // public Image Slika { get; set; }
        public byte[] Slika { get; set; }

        //public string Spol { get; set; }
        public virtual Spolovi  Spol { get; set; }
        public bool Admin { get; set; }
        public List<PolozeniPredmeti> Polozeni { get; set; } = new List<PolozeniPredmeti>();
        public virtual List<KorisniciPredmeti> Uspjeh { get; set; } = new List<KorisniciPredmeti>();

        public override string ToString()
        {
            return $"{Ime} {Prezime} ({KorisnickoIme})";
        }
    }
}

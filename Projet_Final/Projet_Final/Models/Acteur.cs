using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class Acteur
    {
        public Acteur()
        {
            FilmsActeurs = new HashSet<FilmsActeur>();
        }

        public int NoActeur { get; set; }
        public string Nom { get; set; }
        public string Sexe { get; set; }

        public virtual ICollection<FilmsActeur> FilmsActeurs { get; set; }
    }
}

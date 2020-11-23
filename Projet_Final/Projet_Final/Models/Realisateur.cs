using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class Realisateur
    {
        public Realisateur()
        {
            Films = new HashSet<Film>();
        }

        public int NoRealisateur { get; set; }
        public string Nom { get; set; }

        public virtual ICollection<Film> Films { get; set; }
    }
}

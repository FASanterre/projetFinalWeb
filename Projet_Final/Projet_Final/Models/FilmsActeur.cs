using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class FilmsActeur
    {
        public int NoFilm { get; set; }
        public int NoActeur { get; set; }

        public virtual Acteur NoActeurNavigation { get; set; }
        public virtual Film NoFilmNavigation { get; set; }
    }
}

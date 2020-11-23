using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class FilmsSupplement
    {
        public int NoFilm { get; set; }
        public int NoSupplement { get; set; }

        public virtual Film NoFilmNavigation { get; set; }
        public virtual Supplement NoSupplementNavigation { get; set; }
    }
}

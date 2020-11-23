using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class FilmsSousTitre
    {
        public int NoFilm { get; set; }
        public int NoSousTitre { get; set; }

        public virtual Film NoFilmNavigation { get; set; }
        public virtual SousTitre NoSousTitreNavigation { get; set; }
    }
}

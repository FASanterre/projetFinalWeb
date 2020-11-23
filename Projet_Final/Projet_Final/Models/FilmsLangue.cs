using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class FilmsLangue
    {
        public int NoFilm { get; set; }
        public int NoLangue { get; set; }

        public virtual Film NoFilmNavigation { get; set; }
        public virtual Langue NoLangueNavigation { get; set; }
    }
}

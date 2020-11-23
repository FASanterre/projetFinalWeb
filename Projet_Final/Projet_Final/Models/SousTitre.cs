using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class SousTitre
    {
        public SousTitre()
        {
            FilmsSousTitres = new HashSet<FilmsSousTitre>();
        }

        public int NoSousTitre { get; set; }
        public string LangueSousTitre { get; set; }

        public virtual ICollection<FilmsSousTitre> FilmsSousTitres { get; set; }
    }
}

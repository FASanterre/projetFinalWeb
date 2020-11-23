using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class Supplement
    {
        public Supplement()
        {
            FilmsSupplements = new HashSet<FilmsSupplement>();
        }

        public int NoSupplement { get; set; }
        public string Description { get; set; }

        public virtual ICollection<FilmsSupplement> FilmsSupplements { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class Langue
    {
        public Langue()
        {
            FilmsLangues = new HashSet<FilmsLangue>();
        }

        public int NoLangue { get; set; }
        public string Langue1 { get; set; }

        public virtual ICollection<FilmsLangue> FilmsLangues { get; set; }
    }
}

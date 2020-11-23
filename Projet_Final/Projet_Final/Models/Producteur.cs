using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class Producteur
    {
        public Producteur()
        {
            Films = new HashSet<Film>();
        }

        public int NoProducteur { get; set; }
        public string Nom { get; set; }

        public virtual ICollection<Film> Films { get; set; }
    }
}

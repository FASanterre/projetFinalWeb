using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class Format
    {
        public Format()
        {
            Films = new HashSet<Film>();
        }

        public int NoFormat { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Film> Films { get; set; }
    }
}

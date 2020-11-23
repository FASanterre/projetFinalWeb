using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class Category
    {
        public Category()
        {
            Films = new HashSet<Film>();
        }

        public int NoCategorie { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Film> Films { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class ValeursPreference
    {
        public int NoUtilisateur { get; set; }
        public int NoPreference { get; set; }
        public string Valeur { get; set; }

        public virtual UtilisateursPreference No { get; set; }
    }
}

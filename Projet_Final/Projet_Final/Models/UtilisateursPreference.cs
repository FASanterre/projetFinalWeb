using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class UtilisateursPreference
    {
        public int NoUtilisateur { get; set; }
        public int NoPreference { get; set; }

        public virtual Preference NoPreferenceNavigation { get; set; }
        public virtual Utilisateur NoUtilisateurNavigation { get; set; }
        public virtual ValeursPreference ValeursPreference { get; set; }
    }
}

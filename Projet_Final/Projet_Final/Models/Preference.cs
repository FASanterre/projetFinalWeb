using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class Preference
    {
        public Preference()
        {
            UtilisateursPreferences = new HashSet<UtilisateursPreference>();
        }

        public int NoPreference { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UtilisateursPreference> UtilisateursPreferences { get; set; }
    }
}

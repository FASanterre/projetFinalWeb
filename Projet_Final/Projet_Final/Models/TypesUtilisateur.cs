using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class TypesUtilisateur
    {
        public TypesUtilisateur()
        {
            Utilisateurs = new HashSet<Utilisateur>();
        }

        public string TypeUtilisateur { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Utilisateur> Utilisateurs { get; set; }
    }
}

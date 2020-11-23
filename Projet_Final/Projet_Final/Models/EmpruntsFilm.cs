using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class EmpruntsFilm
    {
        public int NoExemplaire { get; set; }
        public int? NoUtilisateur { get; set; }
        public DateTime? DateEmprunt { get; set; }

        public virtual Exemplaire NoExemplaireNavigation { get; set; }
        public virtual Utilisateur NoUtilisateurNavigation { get; set; }
    }
}

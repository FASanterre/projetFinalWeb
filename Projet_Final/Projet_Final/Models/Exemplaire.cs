using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class Exemplaire
    {
        public int NoExemplaire { get; set; }
        public int? NoUtilisateurProprietaire { get; set; }

        public virtual Utilisateur NoUtilisateurProprietaireNavigation { get; set; }
        public virtual EmpruntsFilm EmpruntsFilm { get; set; }
    }
}

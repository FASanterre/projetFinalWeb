using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class Utilisateur
    {
        public Utilisateur()
        {
            EmpruntsFilms = new HashSet<EmpruntsFilm>();
            Exemplaires = new HashSet<Exemplaire>();
            Films = new HashSet<Film>();
            UtilisateursPreferences = new HashSet<UtilisateursPreference>();
        }

        public int NoUtilisateur { get; set; }
        public string NomUtilisateur { get; set; }
        public string Courriel { get; set; }
        public int? MotPasse { get; set; }
        public string TypeUtilisateur { get; set; }

        public virtual TypesUtilisateur TypeUtilisateurNavigation { get; set; }
        public virtual ICollection<EmpruntsFilm> EmpruntsFilms { get; set; }
        public virtual ICollection<Exemplaire> Exemplaires { get; set; }
        public virtual ICollection<Film> Films { get; set; }
        public virtual ICollection<UtilisateursPreference> UtilisateursPreferences { get; set; }
    }
}

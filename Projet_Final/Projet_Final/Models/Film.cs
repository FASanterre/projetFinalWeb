using System;
using System.Collections.Generic;

#nullable disable

namespace Projet_final.Models
{
    public partial class Film
    {
        public Film()
        {
            FilmsActeurs = new HashSet<FilmsActeur>();
            FilmsLangues = new HashSet<FilmsLangue>();
            FilmsSousTitres = new HashSet<FilmsSousTitre>();
            FilmsSupplements = new HashSet<FilmsSupplement>();
        }

        public int NoFilm { get; set; }
        public int? AnneeSortie { get; set; }
        public int? Categorie { get; set; }
        public int? Format { get; set; }
        public DateTime? DataMaj { get; set; }
        public int? NoUtilisateurMaj { get; set; }
        public string Resume { get; set; }
        public int? DureeMinutes { get; set; }
        public bool? FilmOriginal { get; set; }
        public string ImagePochette { get; set; }
        public int? NbDisques { get; set; }
        public string TitreFrancais { get; set; }
        public string TitreOriginal { get; set; }
        public bool? VersionEtendue { get; set; }
        public int? NoRealisateur { get; set; }
        public int? NoProducteur { get; set; }
        public string Xtra { get; set; }

        public virtual Category CategorieNavigation { get; set; }
        public virtual Format FormatNavigation { get; set; }
        public virtual Producteur NoProducteurNavigation { get; set; }
        public virtual Realisateur NoRealisateurNavigation { get; set; }
        public virtual Utilisateur NoUtilisateurMajNavigation { get; set; }
        public virtual ICollection<FilmsActeur> FilmsActeurs { get; set; }
        public virtual ICollection<FilmsLangue> FilmsLangues { get; set; }
        public virtual ICollection<FilmsSousTitre> FilmsSousTitres { get; set; }
        public virtual ICollection<FilmsSupplement> FilmsSupplements { get; set; }
    }
}

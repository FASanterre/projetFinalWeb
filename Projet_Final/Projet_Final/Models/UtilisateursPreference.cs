//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projet_Final.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UtilisateursPreference
    {
        public int NoUtilisateur { get; set; }
        public int NoPreference { get; set; }
    
        public virtual Preference Preference { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
        public virtual ValeursPreference ValeursPreference { get; set; }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ECOLECONDUITEEntities : DbContext
    {
        public ECOLECONDUITEEntities()
            : base("name=ECOLECONDUITEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ELEVE> ELEVEs { get; set; }
        public virtual DbSet<LECON> LECONs { get; set; }
        public virtual DbSet<VEHICULE> VEHICULEs { get; set; }
    
        public virtual int pEleve_INSERT(string nom, Nullable<System.DateTime> dateInscription, string prenom, string rue, string ville, string cp, Nullable<int> creditHoraire)
        {
            var nomParameter = nom != null ?
                new ObjectParameter("nom", nom) :
                new ObjectParameter("nom", typeof(string));
    
            var dateInscriptionParameter = dateInscription.HasValue ?
                new ObjectParameter("dateInscription", dateInscription) :
                new ObjectParameter("dateInscription", typeof(System.DateTime));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("prenom", prenom) :
                new ObjectParameter("prenom", typeof(string));
    
            var rueParameter = rue != null ?
                new ObjectParameter("rue", rue) :
                new ObjectParameter("rue", typeof(string));
    
            var villeParameter = ville != null ?
                new ObjectParameter("ville", ville) :
                new ObjectParameter("ville", typeof(string));
    
            var cpParameter = cp != null ?
                new ObjectParameter("cp", cp) :
                new ObjectParameter("cp", typeof(string));
    
            var creditHoraireParameter = creditHoraire.HasValue ?
                new ObjectParameter("creditHoraire", creditHoraire) :
                new ObjectParameter("creditHoraire", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pEleve_INSERT", nomParameter, dateInscriptionParameter, prenomParameter, rueParameter, villeParameter, cpParameter, creditHoraireParameter);
        }
    }
}

//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class LECON
    {
        public string id { get; set; }
        public System.DateTime dateLecon { get; set; }
        public int heure { get; set; }
        public int duree { get; set; }
        public Nullable<bool> effectueeO_N { get; set; }
        public int idEleve { get; set; }
        public string idVehicule { get; set; }
    
        public virtual ELEVE ELEVE { get; set; }
        public virtual VEHICULE VEHICULE { get; set; }
    }
}
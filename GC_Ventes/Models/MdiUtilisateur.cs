using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class MdiUtilisateur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Pseudo { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public string Gsm { get; set; }
        public string Poste { get; set; }
        public bool? Online { get; set; }
        public byte[] Photo { get; set; }
        public int? IdGroupe { get; set; }
        public string Theme { get; set; }
        public DateTime? DateCreation { get; set; }
        public bool? Supprimer { get; set; }

        public virtual MdiGroupeUtilisateur IdGroupeNavigation { get; set; }
    }
}

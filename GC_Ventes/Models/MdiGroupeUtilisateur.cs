using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class MdiGroupeUtilisateur
    {
        public MdiGroupeUtilisateur()
        {
            MdiUtilisateurs = new HashSet<MdiUtilisateur>();
            WebDroitUsers = new HashSet<WebDroitUser>();
        }

        public int Id { get; set; }
        public string Designation { get; set; }
        public bool? Supprimer { get; set; }

        public virtual ICollection<MdiUtilisateur> MdiUtilisateurs { get; set; }
        public virtual ICollection<WebDroitUser> WebDroitUsers { get; set; }
    }
}

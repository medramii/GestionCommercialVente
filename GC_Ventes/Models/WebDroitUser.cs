using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class WebDroitUser
    {
        public int Id { get; set; }
        public int? IdGoup { get; set; }
        public int? IdPage { get; set; }
        public bool? Droit { get; set; }

        public virtual MdiGroupeUtilisateur IdGoupNavigation { get; set; }
        public virtual WebPage IdPageNavigation { get; set; }
    }
}

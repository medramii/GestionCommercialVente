using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0000Societe
    {
        public string RaisonSociale { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Patente { get; set; }
        public byte[] Logo { get; set; }
        public string PiedDePage { get; set; }
        public string Email { get; set; }
        public bool? OptionTva { get; set; }
        public string OptionSte { get; set; }
        public bool? IsUseSyncParam { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace GC_Ventes.Models
{
    public partial class _0105FactureFournisseur
    {
        public _0105FactureFournisseur()
        {
            _0105DetailFactureFournisseurs = new HashSet<_0105DetailFactureFournisseur>();
        }

        public string NumFacture { get; set; }
        public string NumFactureFournisseur { get; set; }
        public DateTime? DateFacture { get; set; }
        public string CodeFrs { get; set; }
        public float? Remise { get; set; }
        public bool? Validee { get; set; }
        public string Etat { get; set; }
        public bool? Soldee { get; set; }
        public string CodeModeReg { get; set; }
        public DateTime? DateEcheance { get; set; }
        public string Observation { get; set; }
        public string NumPiece { get; set; }
        public double? Temporaire { get; set; }
        public string NumRegFrs { get; set; }
        public double? SoldeRegle { get; set; }
        public byte[] PieceJointe { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreationPar { get; set; }
        public DateTime? ImprerssionDate { get; set; }
        public string ImprerssionPar { get; set; }
        public double? DelaiPaiement { get; set; }
        public DateTime? Datetransfert { get; set; }
        public DateTime? Datevalidation { get; set; }
        public DateTime? Datereglement { get; set; }
        public bool? Transferer { get; set; }
        public DateTime? Datesolder { get; set; }

        public virtual _0400Fournisseur CodeFrsNavigation { get; set; }
        public virtual _1000ModeReglement CodeModeRegNavigation { get; set; }
        public virtual ICollection<_0105DetailFactureFournisseur> _0105DetailFactureFournisseurs { get; set; }
    }
}

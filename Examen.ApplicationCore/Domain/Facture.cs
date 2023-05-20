using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Facture
    {
        //prop+2tab
        public int ProduitId { get; set; }
        //prop de navigation: virtual
        public virtual Produit Produit { get; set; }
        public int FournisseurId { get; set; }
        public virtual Fournissuer Fournisseur { get; set; }
    }
}

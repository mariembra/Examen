using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Produit
    {
        //prop+2tab
        public int ProduitId { get; set; }
        //prop de navigation: virtual
        [DataType(DataType.Date, ErrorMessage = "Invalid Date!")]
        public DateTime DateProd { get; set; }

        public string Destination { get; set; }
        public string Nom { get; set; }
        public double Price { get; set; }
        public virtual List<Facture> Facture { get; set; }
        [ForeignKey("CategorieFk")]
        public virtual Catagorie Categorie { get; set; }
    }
}

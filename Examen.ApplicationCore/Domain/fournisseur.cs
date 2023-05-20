using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Fournissuer
    {
        //prop+2tab
        [Key]
        public int Identifiant { get; set; }
        //prop de navigation: virtual
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public bool IsApproved { get; set; }
        [Range (3, 12, ErrorMessage = "invalid!!")]
        public string nom { get; set; }
        public virtual List<Facture> Facture { get; set; }
    }
}

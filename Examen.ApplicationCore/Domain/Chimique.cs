using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Chimique : Produit
    {
        //prop+2tab
        public string NomLab { get; set; }
        public string Ville { get; set; }
        //prop de navigation: virtual

    }
}

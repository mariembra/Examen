using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Examen.Interfaces;
using Examen.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ExempleService : Service<Exemple>, IExempleService
    {
        public ExempleService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        List<Fournissuer> IExempleService.getfournissuersbycategorie(int categorieId)
        {
            throw new NotImplementedException();
        }
        //implémentation des méthodes
    }
}

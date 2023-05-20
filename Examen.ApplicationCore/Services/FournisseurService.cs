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
    public class FournissuerService : Service<Fournissuer>, IFournisseurService
    {
        public IUnitOfWork _unitOfWork;

        public FournissuerService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        //implémentation des méthodes
        List<Fournissuer> getfournissuersbycategorie(int categorieId)
        {
            return null;
        }

        List<Fournissuer> IFournisseurService.getfournissuersbycategorie(int categorieId)
        {
            throw null;
        }
    }
}

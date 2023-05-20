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
    public class ProduitService : Service<Produit>, IProduitService
    {
        public IUnitOfWork _unitOfWork;
        public ProduitService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Produit> GetProduitListByPrice(double limitPrice)
        {
            return GetAll().OfType<Chimique>().Where(p => p.Price > limitPrice).OrderBy(p => p.Price).Take(5).ToList();
        }


        //implémentation des méthodes
    }
}

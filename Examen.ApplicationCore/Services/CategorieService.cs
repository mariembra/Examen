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
    public class CategorieService : Service<Catagorie>, ICatagorieService
    {
        public IUnitOfWork _unitOfWork;
        public CategorieService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public double GetAGVProductPrice(int categorieId)
        {
            double avgPrice = 0;
            GetById(categorieId).ProduitList.OfType<Biologique>().ToList().ForEach(p =>
            {
                    avgPrice = p.Price;
            });
            return avgPrice / GetById(categorieId).ProduitList.Count();
        }

        public List<Fournissuer> GetFournissuerList(int categorieId)
        {
            List<Fournissuer> FouList = new List<Fournissuer>();
            GetById(categorieId).ProduitList.ForEach(p =>
            {
                FouList.Add(p.Facture.Last().Fournisseur);
            });
            return FouList;
        }
        //implémentation des méthodes
    }
}

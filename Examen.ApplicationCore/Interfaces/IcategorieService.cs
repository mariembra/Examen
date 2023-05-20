using Examen.ApplicationCore.Domain;
using Examen.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface ICatagorieService : IService<Catagorie>
    {
        //signature des méthodes
        List<Fournissuer> GetFournissuerList(int categorieId);
        double GetAGVProductPrice(int categorieId);
    }
}

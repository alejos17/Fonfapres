using System.Collections.Generic;
using Fonfapres.App.Domain;

namespace Fonfapres.App.Data
{
    public interface IPartnerRepo
    {
        IEnumerable<Partner> GetAllPartners();

        Partner AddPartner(Partner partner);

        Partner UpdatePartner(Partner partner);

        void DeletePartner(int idPartner);

        Partner GetPartner(int idPartner);
    }
}
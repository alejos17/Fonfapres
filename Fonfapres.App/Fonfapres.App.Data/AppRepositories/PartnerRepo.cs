using System.Collections.Generic;
using System.Linq;
using Fonfapres.App.Domain;

namespace Fonfapres.App.Data
{
    public class PartnerRepo : IPartnerRepo
    {
        private readonly AppContext _appContext;

        public PartnerRepo(AppContext appContext)
        {
            _appContext = appContext;
        }

        Partner IPartnerRepo.AddPartner(Partner partner)
        {
            var partnerAdded = _appContext.Partners.Add(partner);
            _appContext.SaveChanges();
            return partnerAdded.Entity;
        }

        void IPartnerRepo.DeletePartner(int idPartner)
        {
            var partnerFound = _appContext.Partners.FirstOrDefault(p => p.Id==idPartner); //Revisar busqueda de Id por cedula, pero esta como string no int
            if (partnerFound == null)
                return;
            _appContext.Partners.Remove(partnerFound);
            _appContext.SaveChanges();
        }

        IEnumerable<Partner> IPartnerRepo.GetAllPartners()
        {
            return _appContext.Partners;
        }

        Partner IPartnerRepo.GetPartner(int idPartner)
        {
            return _appContext.Partners.FirstOrDefault(p => p.Id == idPartner);
        }

        Partner IPartnerRepo.UpdatePartner(Partner partner)
        {
            var partnerFound = _appContext.Partners.FirstOrDefault(p => p.Id == partner.Id);
            if(partnerFound!=null)
            {
                partnerFound.idPerson = partner.idPerson;
                partnerFound.name = partner.name;
                partnerFound.lastName = partner.lastName;
                partnerFound.bornDate = partner.bornDate;
                partnerFound.city = partner.city;
                partnerFound.address = partner.address;
                partnerFound.phoneNumber = partner.phoneNumber;
                partnerFound.mobileNumber = partner.mobileNumber;
                partnerFound.email = partner.email;
                partnerFound.code = partner.code;
                partnerFound.datein = partner.datein;
                partnerFound.dateout = partner.dateout;
                partnerFound.fam = partner.fam;
                partnerFound.recPerson = partner.recPerson;
                partnerFound.idrecPerson = partner.idrecPerson;
                partnerFound.avalador = partner.avalador;

                _appContext.SaveChanges();
            }

            return partnerFound;
        }
    }
}
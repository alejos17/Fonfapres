using System;
using System.Collections.Generic;
using Fonfapres.App.Domain;
using Fonfapres.App.Data;

namespace Fonfapres.App.Console
{
    class Program
    {
        //LLamo instancia de Repositorio Asociado
        private static IPartnerRepo _repoPartner= new PartnerRepo(new Data.AppContext());
        
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //AddPartner();

        }

        private static void AddPartner()
        {
            var partner = new Partner
            {
                idPerson = "16078823",
                name = "Alejandro David",
                lastName = "Tamayo Zuluaga",
                bornDate = "17/02/1984",
                city = "Manizales",
                address = "Carrera 12 # 47K 09",
                phoneNumber = "8761720",
                mobileNumber = "3008710153",
                email = "alejos17@gmail.com",
                code = "TAMZ02",
                datein = "1/1/2010",
                dateout = null,
                fam = "Tamayo",
                recPerson = null,
                idrecPerson = null,
                avalador = null
            };
            _repoPartner.AddPartner(partner);
        }

    }
}

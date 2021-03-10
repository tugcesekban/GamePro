using GamePro.Abstracts;
using GamePro.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePro.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalId),
                                                 gamer.FirstName.ToUpper(),
                                                 gamer.Surname.ToUpper(),
                                                 gamer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}

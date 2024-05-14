using MernisServiceReference;
using ProjectDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectDemo
{
    public class MernisServiceAdapter : ICustomerCheckService
    {

        public bool CheckIfRealPerson(Customer customer )
        {   
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.Name.ToUpper(), customer.Surname.ToUpper(), customer.DateOfBirth.Year);
            return result.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}



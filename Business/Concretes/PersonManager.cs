using Business.Abstracts;
using Entities.Concretes;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class PersonManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {
        throw new NotImplementedException();
    }

    public bool CheckPerson(Person person)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        return client.TCKimlikNoDogrulaAsync(person.NationalIdentity, person.FirstName,person.LastName, person.DateOfBirthYear).Result.Body.TCKimlikNoDogrulaResult;
    }

    public List<Person> GetList()
    {
        throw new NotImplementedException();
    }
}

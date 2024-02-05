using Business.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class PttManager:ISupplierManager
{
    private IApplicantService _applicantService;

    public PttManager(IApplicantService applicantService)
    {
         _applicantService = applicantService;
    }
    public void GiveMask(Person person)
    {
        if (_applicantService.CheckPerson(person))
        {
            Console.WriteLine("maske verildi"+person.FirstName);
        }
        else
        {
            Console.WriteLine("maske verilemedi "+person.FirstName);
        }
    }
}

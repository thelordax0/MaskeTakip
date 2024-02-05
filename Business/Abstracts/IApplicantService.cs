﻿using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IApplicantService
{

    public void ApplyForMask(Person person);

    public List<Person> GetList();

    public bool CheckPerson(Person person);
}

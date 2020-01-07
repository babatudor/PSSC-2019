using System;
using System.Collections.Generic;
using System.Text;
using Business.Domain;

namespace Business.Service
{
    interface IService
    {
        string RegisterNewPerson();
        string ProvidePersonInformation();
        void AddPersonInformation();
        void ChangePersonStatus();

        IEnumerable<PersonEntity> GetAllPersons();

    }
}

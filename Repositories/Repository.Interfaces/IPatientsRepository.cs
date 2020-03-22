using Cov19.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cov19.Repositories.Repository.Interfaces
{
    public interface IPatientsRepository
    {
        IEnumerable<Patients> GetAllPatients();

        Patients GetPatientsById(int id);

        void Add(Patients patients);

        void Edit(Patients patients);

        void Delete(Patients patients);

        void AgeCalc(Patients patients, DateTime dateOfBirth);

        void BolniotOzdraveniotIMrtviot(Patients patients, bool infected, bool recovered, bool dead);
    }
}

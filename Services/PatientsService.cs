using Cov19.Data.Entities;
using Cov19.Repositories.Repository.Interfaces;
using Cov19.Services.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cov19.Services
{
    public class PatientsService : IPatientsService
    {
        private readonly IPatientsRepository _patientsRepository;

        public PatientsService(IPatientsRepository patientsRepository)
        {
            _patientsRepository = patientsRepository;
        }

        public void Add(Patients patients)
        {
            _patientsRepository.Add(patients);
        }

        public void Delete(Patients patients)
        {
            _patientsRepository.Delete(patients);
        }

        public void Edit(Patients patients)
        {
            _patientsRepository.Edit(patients);
        }

        public void AgeCalc(Patients patients, DateTime dateOfBirth)
        {
            _patientsRepository.AgeCalc(patients, dateOfBirth);
        }

        public void BolniotOzdraveniotIMrtviot(Patients patients, bool infected, bool recovered, bool dead)
        {
            _patientsRepository.BolniotOzdraveniotIMrtviot(patients,infected,recovered,dead);
        }

        public IEnumerable<Patients> GetAllPatients()
        {
            var result = _patientsRepository.GetAllPatients();
            return result;
        }

        public Patients GetPatientsById(int id)
        {
            var result = _patientsRepository.GetPatientsById(id);
            return result;
        }
    }
}

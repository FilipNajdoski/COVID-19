using Cov19.Data;
using Cov19.Data.Entities;
using Cov19.Repositories.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cov19.Repositories
{
    public class PatientsRepository : IPatientsRepository
    {
        private readonly DataContext _context;

        public PatientsRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(Patients patients)
        {
            _context.Patients.Add(patients);
            _context.SaveChanges();
        }

        public void Delete(Patients patients)
        {
            _context.Patients.Remove(patients);
            _context.SaveChanges();
        }

        public void Edit(Patients patients)
        {
            _context.Patients.Update(patients);
            _context.SaveChanges();
        }

        public void AgeCalc(Patients patients, DateTime dateOfBirth)
        {
            patients.DateOfBirth = dateOfBirth;
            DateTime now = DateTime.Now;
            int age = now.Year - dateOfBirth.Year;

            if (dateOfBirth > now.AddYears(-age))
                age--;

            patients.Age = age;
            _context.Patients.Update(patients);
            _context.SaveChanges();
        }

        public void BolniotOzdraveniotIMrtviot(Patients patients, bool infected, bool recovered, bool dead)
        {
            if (infected == true)
            {
                patients.Infected = true;
                patients.Recovered = false;
                patients.Dead = false;
                patients.Status = "Infected";
                patients.LatestStatusDate = patients.DateOfInfection;
                _context.Patients.Update(patients);
                _context.SaveChanges();
            }

            if (recovered == true)
            {
                patients.Infected = false;
                patients.Recovered = true;
                patients.Dead = false;
                patients.Status = "Recovered";
                patients.LatestStatusDate = patients.DateOfRecoveryDeath;
                patients.Hospitalized = false;
                patients.HomeTreated = false;
                _context.Patients.Update(patients);
                _context.SaveChanges();
            }

            if (dead == true)
            {
                patients.Infected = false;
                patients.Recovered = false;
                patients.Dead = true;
                patients.Status = "Dead";
                patients.LatestStatusDate = patients.DateOfRecoveryDeath;
                patients.Hospitalized = false;
                patients.HomeTreated = false;
                _context.Patients.Update(patients);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Patients> GetAllPatients()
        {
            var result = _context.Patients.AsEnumerable();
            return result;
        }

        public Patients GetPatientsById(int id)
        {
            var result = _context.Patients.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}

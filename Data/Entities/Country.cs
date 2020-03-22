using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cov19.Data.Entities
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


        // Da se dobiva po bool od patients if ((patients.DateOfInfection != null || != DateTime.MinValue ) && patients.Country == country.Name)
        public int TotalInfectedInCountry { get; set; }
        // Da se dobiva po bool od patients if (patients.Recovered == true && patients.Country == country.Name)
        public int TotalRecoveredInCountry { get; set; }
        // Da se dobiva po bool od patients if (patients.Dead == true && patients.Country == country.Name)
        public int TotalDeadInCountry { get; set; }
        // Da se dobiva po bool od patients if (patients.Infected == true && patients.Country == country.Name)
        public int CurrentlyInfectedInCountry { get; set; }
        //Da se dobiva po bool od patients if (patients.Hospitalized == true && patients.country.Name)
        public int CurrentlyHospitalizedCasesInCountry{ get; set; }
        //Da se dobiva po bool od patients if (patients.HomeTreated == true && patients.country.Name)
        public int CurrentlyHomeTreatedCasesInCountry { get; set; }
    }
}

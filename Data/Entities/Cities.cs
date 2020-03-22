using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cov19.Data.Entities
{
    public class Cities
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }



        // Da se dobiva po bool od patients if ((patients.DateOfInfection != null || != DateTime.MinValue) && patients.City == cities.Name)
        public int TotalInfectedInCity { get; set; }
        // Da se dobiva po bool od patients if (patients.Recovered == true && patients.City == cities.Name)
        public int TotalRecoveredInCity { get; set; }
        // Da se dobiva po bool od patients if (patients.Recovered == true && patients.City == cities.Name)
        public int TotalDeadInCity { get; set; }
        // Da se dobiva po bool od patients if (patients.Infected == true && patients.City == cities.Name)
        public int CurrentlyInfectedInCity { get; set; } 
        //Da se dobiva po bool od patients if (patients.Hospitalized == true && patients.City == Name)
        public int CurrentlyHospitalizedCasesInCity { get; set; }
        //Da se dobiva po bool od patients if (patients.HomeTreated == true && patients.City == Name)
        public int CurrentlyHomeTreatedCasesInCity { get; set; }
    }
}

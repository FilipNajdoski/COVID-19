using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cov19.Data.Entities
{
    public class Hospitals
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        //Da se dobiva po bool od patients if (patients.Hospitalized == true && patients.Hospital == hospitals.Name)
        public int CurrentlyHospitalizedPatients { get; set; }
    }
}

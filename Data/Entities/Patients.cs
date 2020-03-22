using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cov19.Data.Entities
{
    public class Patients
    {
        [Key]
        public int Id { get; set; }

        //Osnovni informacii

        public string NameAndSurname { get; set; }
        public int UniqueIdNumber { get; set; }
        public string IdNumber { get; set; }
        public string Adress { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        //Se dobiva od metod za presmetka prema DateOfBirth
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        //Ne e vneseno se mislam kako da go vrzam so hospitalisied ....
        public string Hospital { get; set; }

        //Status

        public string Status { get; set; }
        public bool Infected { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfInfection { get; set; }
        public string CauseOfInfection { get; set; }
        //Se dobiva vo metod od DateOfInfection i DateOfRecoveryDeath
        [DataType(DataType.Date)]
        public DateTime LatestStatusDate { get; set; }
        public bool Recovered { get; set; }
        public bool Dead { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfRecoveryDeath { get; set; }
        //Boolovi za bolnici brojka za momentalno hospitalizirani ili domasentretman
        public bool Hospitalized { get; set; }
        public bool HomeTreated { get; set; }
        public int TimeToRecovery { get; set; }
    }
}

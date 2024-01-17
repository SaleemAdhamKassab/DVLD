using DVLD_DataAccess;
using Sahred.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public class Application
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public byte Status { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal Fees { get; set; }


        public int PersonId { get; set; }
        public Person Person { get; set; }

        public int CreatedByUserId { get; set; }
        public User User { get; set; }

        public byte ApplicationTypeId { get; set; }
        public ApplicationType ApplicationType { get; set; }


        public static int getActiveApplicationIDForLicenseClass(int personId, int applicationTypeId, int licenseClassID) => ApplicationData.getActiveApplicationIDForLicenseClass(personId, applicationTypeId, licenseClassID);

        public static ApplicationDto get(int id) => ApplicationData.get(id);

        public static bool updateApplicationStatus(int applicationId,byte statusId) => ApplicationData.updateApplicationStatus(applicationId,statusId);

        public static int post(ApplicationDto applicationDto) => ApplicationData.post(applicationDto);
    }
}
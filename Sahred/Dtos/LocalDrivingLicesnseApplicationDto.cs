using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Sahred.Dtos
{
    public class LocalDrivingLicesnseApplicationDto
    {
        public int Id { get; set; }

        public int ApplicationId { get; set; }
        public ApplicationDto ApplicationDto { get; set; }

        public int LicenseClassId { get; set; }
        public LicenseClassDto LicenseClassDto { get; set; }

        public byte ApplicationTypeId { get; set; }
        public ApplicationTypeDto ApplicationTypeDto { get; set; }

        public int PersonId { get; set; }
        public PersonDto PersonDto { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahred.Dtos
{
    public class TestAppointmentDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsLocked { get; set; }


        public int TestTypeId { get; set; }
        public TestTypeDto TestTypeDto { get; set; }

        public int CreatedByUserId { get; set; }
        public UserDto UserDto { get; set; }

        public int LocalDrivingLicenseApplicationId { get; set; }
        public LocalDrivingLicesnseApplicationDto LocalDrivingLicesnseApplicationDto { get; set; }

    }
}

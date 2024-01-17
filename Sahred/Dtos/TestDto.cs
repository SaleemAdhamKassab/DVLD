using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahred.Dtos
{
    public class TestDto
    {
        public int Id { get; set; }
        public bool Result { get; set; }
        public string Notes { get; set; }


        public int TestAppointmentId { get; set; }
        public TestAppointmentDto TestAppointmentDto { get; set; }


        public int CreatedByUserId { get; set; }
        public UserDto UserDto { get; set; }
    }
}
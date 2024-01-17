using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahred.Dtos
{
    public class ApplicationDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public byte Status { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal Fees { get; set; }


        public int PersonId { get; set; }
        public PersonDto PersonDto { get; set; }

        public int CreatedByUserId { get; set; }
        public UserDto UserDto { get; set; }

        public byte ApplicationTypeId { get; set; }
        public ApplicationTypeDto ApplicationTypeDto { get; set; }

    }
}
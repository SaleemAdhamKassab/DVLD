namespace Sahred.Dtos
{
    public class DriverDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }


        public int PersonId { get; set; }
        public PersonDto PersonDto { get; set; }

        public int CreatedByUserId { get; set; }
        public UserDto UserDto { get; set; }
    }
}
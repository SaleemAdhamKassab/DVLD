namespace Sahred.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int PersonId { get; set; }
        public PersonDto PersonDto { get; set; }
    }
}

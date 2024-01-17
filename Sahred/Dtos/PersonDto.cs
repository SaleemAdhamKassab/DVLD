namespace Sahred.Dtos
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string NationalNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public short Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
        public int CountryId { get; set; }
    }
}
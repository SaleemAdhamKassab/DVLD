using DVLD_DataAccess;
using Sahred.Dtos;
using System.Data;
using static Sahred.Helper;

namespace DVLD_Buisness
{
    public class Person
    {
        public EnMode Mode = EnMode.Add;

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
        public bool Save
        {
            get
            {
                switch (Mode)
                {
                    case EnMode.Add:
                        if (_add())
                        {
                            Mode = EnMode.Update;
                            return true;
                        }
                        else
                            return false;

                    case EnMode.Update:
                        return _update();
                }

                return false;
            }
        }

        private PersonDto _getPersonDto() => new()
        {
            NationalNumber = NationalNumber,
            FirstName = FirstName,
            SecondName = SecondName,
            LastName = LastName,
            DateOfBirth = DateOfBirth,
            Gender = Gender,
            Address = Address,
            Phone = Phone,
            Email = Email,
            ImagePath = ImagePath,
            CountryId = CountryId
        };

        private bool _add()
        {
            Id = PersonData.Post(_getPersonDto());
            return Id != -1;
        }

        private bool _update() => PersonData.Put(Id, _getPersonDto());

        public static Person Get(int id, string nationalNo)
        {
            PersonDto personDto = PersonData.Get(id, nationalNo);

            return new Person()
            {
                Id = personDto.Id,
                NationalNumber = personDto.NationalNumber,
                FirstName = personDto.FirstName,
                SecondName = personDto.SecondName,
                LastName = personDto.LastName,
                DateOfBirth = personDto.DateOfBirth,
                Email = personDto.Email,
                Phone = personDto.Phone,
                Address = personDto.Address,
                CountryId = personDto.CountryId,
                Gender = personDto.Gender,
                ImagePath = personDto.ImagePath
            };
        }

        public static DataTable Get() => PersonData.Get();

        public static bool IsNationalNumberExists(string nationalNumber) => PersonData.IsNationalNumberExists(nationalNumber);

        public static bool Delete(int id) => PersonData.Delete(id);
    }
}
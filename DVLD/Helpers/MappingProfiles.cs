using DVLD_Buisness;
using DVLD_DataAccess;
using Sahred.Dtos;

namespace DVLD.Helpers
{
    internal class MappingProfiles
    {
        public static Person PersonDtoToPerson(PersonDto personDto, Person person)
        {
            if (personDto is null)
                return null;

            person.Id = personDto.Id;
            person.NationalNumber = personDto.NationalNumber;
            person.FirstName = personDto.FirstName;
            person.SecondName = personDto.SecondName;
            person.LastName = personDto.LastName;
            person.DateOfBirth = personDto.DateOfBirth;
            person.Gender = personDto.Gender;
            person.Address = personDto.Address;
            person.Phone = personDto.Phone;
            person.Email = personDto.Email;
            person.ImagePath = personDto.ImagePath;
            person.CountryId = personDto.CountryId;

            return person;
        }

        public static User UserDtoToUser(UserDto userDto, User user)
        {
            if (userDto is null)
                return null;

            user.Person = new();

            user.Id = userDto.Id;
            user.UserName = userDto.UserName;
            user.Password = userDto.Password;
            user.IsActive = userDto.IsActive;
            user.PersonId = userDto.PersonId;
            user.Person = PersonDtoToPerson(userDto.PersonDto, user.Person);

            return user;
        }

        public static ApplicationType ApplicationTypeDtoToApplicationType(ApplicationTypeDto applicationTypeDto, ApplicationType applicationType)
        {
            if (applicationTypeDto is null)
                return null;

            applicationType.Id = applicationTypeDto.Id;
            applicationType.Title = applicationTypeDto.Title;
            applicationType.Fees = applicationTypeDto.Fees;

            return applicationType;
        }

        public static DVLD_Buisness.Application ApplicationdToDtoApplication(ApplicationDto applicationdto, DVLD_Buisness.Application application)
        {
            if (applicationdto is null)
                return null;

            application.ApplicationType = new();
            application.Person = new();

            application.Id = applicationdto.Id;
            application.Date = applicationdto.Date;
            application.Status = applicationdto.Status;
            application.LastStatusDate = applicationdto.LastStatusDate;
            application.Fees = applicationdto.Fees;
            application.PersonId = applicationdto.PersonId;
            application.CreatedByUserId = applicationdto.CreatedByUserId;
            application.ApplicationTypeId = applicationdto.ApplicationTypeId;
            application.ApplicationType = ApplicationTypeDtoToApplicationType(applicationdto.ApplicationTypeDto, application.ApplicationType);
            application.Person = PersonDtoToPerson(applicationdto.PersonDto, application.Person);

            return application;
        }

        public static LicenseClass LicenseClassDtoToLicenseClass(LicenseClassDto licenseClassDto)
        {
            if (licenseClassDto is null)
                return null;

            LicenseClass licenseClass = new();

            licenseClass.Id = licenseClassDto.Id;
            licenseClass.Name = licenseClassDto.Name;
            licenseClass.Description = licenseClassDto.Description;
            licenseClass.MinimumAllowedAge = licenseClassDto.MinimumAllowedAge;
            licenseClass.DefaultValidityLength = licenseClassDto.DefaultValidityLength;
            licenseClass.Fees = licenseClassDto.Fees;

            return licenseClass;
        }

        public static LocalDrivingLicesnseApplication LocalDrivingLicesnseApplicationDtoToLocalDrivingLicesnseApplication(LocalDrivingLicesnseApplicationDto localDrivingLicesnseApplicationDto, LocalDrivingLicesnseApplication localDrivingLicesnseApplication)
        {
            if (localDrivingLicesnseApplicationDto is null)
                return null;

            localDrivingLicesnseApplication = new();
            localDrivingLicesnseApplication.Application = new();
            localDrivingLicesnseApplication.LicenseClass = new();
            localDrivingLicesnseApplication.ApplicationType = new();
            localDrivingLicesnseApplication.Person = new();

            localDrivingLicesnseApplication.Id = localDrivingLicesnseApplicationDto.Id;
            localDrivingLicesnseApplication.ApplicationId = localDrivingLicesnseApplicationDto.ApplicationId;
            localDrivingLicesnseApplication.LicenseClassId = localDrivingLicesnseApplicationDto.LicenseClassId;

            localDrivingLicesnseApplication.Application = ApplicationdToDtoApplication(localDrivingLicesnseApplicationDto.ApplicationDto, localDrivingLicesnseApplication.Application);
            localDrivingLicesnseApplication.LicenseClass = LicenseClassDtoToLicenseClass(localDrivingLicesnseApplicationDto.LicenseClassDto, localDrivingLicesnseApplication.LicenseClass);
            localDrivingLicesnseApplication.ApplicationType = ApplicationTypeDtoToApplicationType(localDrivingLicesnseApplicationDto.ApplicationTypeDto, localDrivingLicesnseApplication.ApplicationType);
            localDrivingLicesnseApplication.Person = PersonDtoToPerson(localDrivingLicesnseApplicationDto.PersonDto, localDrivingLicesnseApplication.Person);

            return localDrivingLicesnseApplication;
        }

        public static TestType TestTypeDtoToTestType(TestTypeDto testTypeDto, TestType testType)
        {
            if (testTypeDto is null)
                return null;

            testType.Id = testTypeDto.Id;
            testType.Title = testTypeDto.Title;
            testType.Description = testTypeDto.Description;
            testType.Fees = testTypeDto.Fees;

            return testType;
        }

        public static LicenseClass LicenseClassDtoToLicenseClass(LicenseClassDto licenseClassDto, LicenseClass licenseClass)
        {
            if (licenseClassDto is null)
                return null;

            licenseClass.Id = licenseClassDto.Id;
            licenseClass.Name = licenseClassDto.Name;
            licenseClass.Description = licenseClassDto.Description;
            licenseClass.MinimumAllowedAge = licenseClassDto.MinimumAllowedAge;
            licenseClass.DefaultValidityLength = licenseClassDto.DefaultValidityLength;
            licenseClass.Fees = licenseClassDto.Fees;

            return licenseClass;
        }

        public static TestAppointment TestAppointmentDtoToTestAppointment(TestAppointmentDto testAppointmentDto, TestAppointment testAppointment)
        {
            if (testAppointmentDto is null)
                return null;

            testAppointment.Id = testAppointmentDto.Id;
            testAppointment.Date = testAppointmentDto.Date;
            testAppointment.PaidFees = testAppointmentDto.PaidFees;
            testAppointment.IsLocked = testAppointmentDto.IsLocked;
            testAppointment.TestTypeId = testAppointmentDto.TestTypeId;
            testAppointment.LocalDrivingLicenseApplicationId = testAppointmentDto.LocalDrivingLicenseApplicationId;
            testAppointment.CreatedByUserId = testAppointmentDto.CreatedByUserId;

            return testAppointment;
        }

        public static Test TestDtoToTest(TestDto testDto, Test test)
        {
            if (testDto is null)
                return null;

            test.Id = testDto.Id;
            test.Result = testDto.Result;
            test.Notes = testDto.Notes;
            test.TestAppointmentId = testDto.TestAppointmentId;
            test.CreatedByUserId = testDto.CreatedByUserId;

            return test;
        }

        public static Driver DriverDtoToDriver(DriverDto driverDto, Driver driver)
        {
            if (driverDto is null)
                return null;

            driver.Id = driverDto.Id;
            driver.Date = driverDto.Date;
            driver.PersonId = driverDto.PersonId;
            driver.CreatedByUserId = driverDto.CreatedByUserId;

            return driver;
        }

        public static License LicenseDtoToLicense(LicenseDto licenseDto, License license)
        {
            if (licenseDto is null)
                return null;

            license.Application = new();
            license.LicenseClass = new();
            license.User = new();
            license.Driver = new();

            license.ApplicationId = licenseDto.ApplicationId;
            license.LicenseClassId = licenseDto.LicenseClassId;
            license.CreatedByUserId = licenseDto.CreatedByUserId;
            license.DriverId = licenseDto.DriverId;

            license.Id = licenseDto.Id;
            license.IssueDate = licenseDto.IssueDate;
            license.ExpirationDate = licenseDto.ExpirationDate;
            license.Notes = licenseDto.Notes;
            license.PaidFees = licenseDto.PaidFees;
            license.IsActive = licenseDto.IsActive;
            license.IssueReason = licenseDto.IssueReason;


            license.Application = ApplicationdToDtoApplication(licenseDto.ApplicationDto, license.Application);
            license.LicenseClass = LicenseClassDtoToLicenseClass(licenseDto.LicenseClassDto, license.LicenseClass);
            license.User = UserDtoToUser(licenseDto.UserDto, license.User);
            license.Driver = DriverDtoToDriver(licenseDto.DriverDto, license.Driver);

            return license;
        }
    }
}
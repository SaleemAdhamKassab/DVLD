namespace Sahred.Dtos
{
    public class DetainedLicenseDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal FineFees { get; set; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }


        public int LicenseId { get; set; }
        public LicenseDto LicenseDto { get; set; }

        public int CreatedByUserId { get; set; }
        public UserDto UserDto { get; set; }

        public int? ReleasedByUserId { get; set; }
        public UserDto? ReleasedByUserDto { get; set; }

        public int? ApplicationId { get; set; }
        public ApplicationDto? ApplicationDto { get; set; }

    }
}

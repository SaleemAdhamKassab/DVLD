using static System.Net.Mime.MediaTypeNames;

namespace Sahred.Dtos
{
    public class LicenseDto
    {
        public int Id { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string? Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }


        public int ApplicationId { get; set; }
        public ApplicationDto ApplicationDto { get; set; }

        public int DriverId { get; set; }
        public DriverDto DriverDto { get; set; }

        public int LicenseClassId { get; set; }
        public LicenseClassDto LicenseClassDto { get; set; }

        public int CreatedByUserId { get; set; }
        public UserDto UserDto { get; set; }
    }
}

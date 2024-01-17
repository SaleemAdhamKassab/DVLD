namespace Sahred.Dtos
{
    public class InternationalLicensesDto
    {
        public int Id { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }


        public int ApplicationId { get; set; }
        public int DriverId { get; set; }
        public int IssuedUsingLocalLicenseId { get; set; }
        public int CreatedByUserID { get; set; }
    }
}

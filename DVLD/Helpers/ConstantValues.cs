namespace DVLD.Helpers
{
    public class ConstantValues
    {
        public enum enFormMode { Add, Update }

        public enum enApplicationType { NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3, ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7 }

        public enum enLicenseClasses { ClassA = 1 }

        public enum enApplicationServicesFees { NewLocalDrivingLicenseService = 15, RenewDrivingLicense = 2, ReplacementForLostDrivingLicense = 10, ReplacementForDamagedDrivingLicense = 5 }

        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 }

        public enum enTestType { Vision = 1, Written = 2, Street = 3 }

        public enum enTestMode { ScheduleTest, TakeTest }

        public enum enIssueReason { FirstTime = 1, Renew = 2, ReplacementForDamaged = 3, ReplacementForLost = 4 }

        public enum enLicenseClass { class3 = 10 }

        public enum enInternationalValidityLength { OneYear = 1 }
    }
}

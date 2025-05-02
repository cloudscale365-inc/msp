using System;
using System.Collections.Generic;

namespace CustomerOnboardingWorkflow.Models
{
    /// <summary>
    /// Contains Office 365 specific information for customer onboarding
    /// </summary>
    public class Office365Info
    {
        public bool HasExistingLicenses { get; set; }
        public int NumberOfLicenses { get; set; }
        public string LicenseType { get; set; } = string.Empty;
        public bool HasProvidedCredentials { get; set; }
        public string AdminUsername { get; set; } = string.Empty;
        public string AdminPassword { get; set; } = string.Empty; // Note: In a real app, use secure string or better security
        public string TenantId { get; set; } = string.Empty;
        public string Domain { get; set; } = string.Empty;
        public List<string> RequiredServices { get; set; } = new List<string>(); // Exchange, SharePoint, Teams, etc.
        public string MigrationSource { get; set; } = string.Empty; // e.g., "Google Workspace", "On-premises Exchange"
        public bool RequiresMigration { get; set; }
        public DateTime? ScheduledMigrationDate { get; set; }
        public string MigrationNotes { get; set; } = string.Empty;
        public bool SetupComplete { get; set; }
        public string SetupNotes { get; set; } = string.Empty;
    }
}

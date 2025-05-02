using System;
using System.Collections.Generic;

namespace CustomerOnboardingWorkflow.Models
{
    /// <summary>
    /// Contains SaaS and cloud monitoring specific information for customer onboarding
    /// </summary>
    public class SaasCloudMonitoringInfo
    {
        // SaaS applications inventory
        public List<SaasApplication> SaasApplications { get; set; } = new List<SaasApplication>();
        public int TotalSaasApplications { get; set; }
        public bool InventoryComplete { get; set; }
        
        // Cloud services inventory
        public List<CloudService> CloudServices { get; set; } = new List<CloudService>();
        public int TotalCloudServices { get; set; }
        public bool CloudInventoryComplete { get; set; }
        
        // Monitoring setup
        public bool MonitoringConfigured { get; set; }
        public string MonitoringSolution { get; set; } = string.Empty;
        public List<string> MonitoredMetrics { get; set; } = new List<string>();
        public bool AlertingConfigured { get; set; }
        public List<string> AlertRecipients { get; set; } = new List<string>();
        
        // Security and compliance
        public bool SecurityAssessmentComplete { get; set; }
        public List<string> ComplianceRequirements { get; set; } = new List<string>(); // GDPR, HIPAA, etc.
        public bool ComplianceVerified { get; set; }
        
        // Documentation
        public bool ServicesDocumented { get; set; }
        public string DocumentationLocation { get; set; } = string.Empty;
        public string AdditionalNotes { get; set; } = string.Empty;
    }
    
    /// <summary>
    /// Represents a SaaS application used by the customer
    /// </summary>
    public class SaasApplication
    {
        public string Name { get; set; } = string.Empty;
        public string Vendor { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string AdminUsername { get; set; } = string.Empty;
        public string AdminPassword { get; set; } = string.Empty; // Note: In a real app, use secure storage
        public string SubscriptionType { get; set; } = string.Empty;
        public DateTime SubscriptionRenewalDate { get; set; }
        public int NumberOfUsers { get; set; }
        public bool HasApiAccess { get; set; }
        public string ApiCredentials { get; set; } = string.Empty;
        public bool IsMonitored { get; set; }
        public List<string> MonitoredFeatures { get; set; } = new List<string>();
        public string Notes { get; set; } = string.Empty;
    }
    
    /// <summary>
    /// Represents a cloud service used by the customer
    /// </summary>
    public class CloudService
    {
        public string Name { get; set; } = string.Empty;
        public string Provider { get; set; } = string.Empty; // AWS, Azure, GCP, etc.
        public string ServiceType { get; set; } = string.Empty; // VM, Storage, Database, etc.
        public string Region { get; set; } = string.Empty;
        public string AccountId { get; set; } = string.Empty;
        public string AdminUsername { get; set; } = string.Empty;
        public string AdminPassword { get; set; } = string.Empty; // Note: In a real app, use secure storage
        public bool HasApiAccess { get; set; }
        public string ApiCredentials { get; set; } = string.Empty;
        public bool IsMonitored { get; set; }
        public List<string> MonitoredMetrics { get; set; } = new List<string>();
        public string Notes { get; set; } = string.Empty;
    }
}

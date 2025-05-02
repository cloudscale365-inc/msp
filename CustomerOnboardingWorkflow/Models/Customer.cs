using System;
using System.Collections.Generic;

namespace CustomerOnboardingWorkflow.Models
{
    /// <summary>
    /// Represents a customer in the onboarding process
    /// </summary>
    public class Customer
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string CompanyName { get; set; } = string.Empty;
        public string PrimaryAddress { get; set; } = string.Empty;
        public List<string> AdditionalAddresses { get; set; } = new List<string>();
        
        // Primary contact information
        public string ContactName { get; set; } = string.Empty;
        public string ContactEmail { get; set; } = string.Empty;
        public string ContactPhone { get; set; } = string.Empty;
        
        // Contract information
        public string ContractNumber { get; set; } = string.Empty;
        public DateTime ContractSignDate { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractEndDate { get; set; }
        
        // Selected services
        public bool HasOffice365Services { get; set; }
        public bool HasNetworkMonitoring { get; set; }
        public bool HasServerManagement { get; set; }
        public bool HasSaasCloudMonitoring { get; set; }
        public bool HasHosting { get; set; }
        
        // Service-specific information
        public Office365Info? Office365Information { get; set; }
        public NetworkMonitoringInfo? NetworkMonitoringInformation { get; set; }
        public ServerManagementInfo? ServerManagementInformation { get; set; }
        public SaasCloudMonitoringInfo? SaasCloudMonitoringInformation { get; set; }
        public HostingInfo? HostingInformation { get; set; }
        
        // Notes and additional information
        public string Notes { get; set; } = string.Empty;
        public DateTime OnboardingStartDate { get; set; } = DateTime.Now;
        public DateTime? OnboardingCompletionDate { get; set; }
        public string OnboardingStatus { get; set; } = "In Progress";
    }
}

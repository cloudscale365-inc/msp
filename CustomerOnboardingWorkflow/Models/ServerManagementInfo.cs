using System;
using System.Collections.Generic;

namespace CustomerOnboardingWorkflow.Models
{
    /// <summary>
    /// Contains server management specific information for customer onboarding
    /// </summary>
    public class ServerManagementInfo
    {
        public bool AccessGranted { get; set; }
        public string AccessMethod { get; set; } = string.Empty; // RDP, SSH, VPN, etc.
        public string AdminCredentials { get; set; } = string.Empty; // Note: In a real app, use secure storage
        
        // Server inventory
        public List<ServerInfo> Servers { get; set; } = new List<ServerInfo>();
        public int TotalServers { get; set; }
        public bool InventoryComplete { get; set; }
        
        // Management setup
        public bool MonitoringAgentsInstalled { get; set; }
        public bool BackupConfigured { get; set; }
        public string BackupSolution { get; set; } = string.Empty;
        public string BackupSchedule { get; set; } = string.Empty;
        public bool PatchManagementConfigured { get; set; }
        public string PatchSchedule { get; set; } = string.Empty;
        
        // Security assessment
        public bool SecurityAssessmentComplete { get; set; }
        public int CriticalSecurityIssues { get; set; }
        public int HighSecurityIssues { get; set; }
        public int MediumSecurityIssues { get; set; }
        public int LowSecurityIssues { get; set; }
        public bool SecurityIssuesReported { get; set; }
        public DateTime? SecurityReportDate { get; set; }
        
        // Documentation
        public bool ServersDocumented { get; set; }
        public string DocumentationLocation { get; set; } = string.Empty;
        public string AdditionalNotes { get; set; } = string.Empty;
    }
    
    /// <summary>
    /// Represents a server in the customer environment
    /// </summary>
    public class ServerInfo
    {
        public string Name { get; set; } = string.Empty;
        public string IpAddress { get; set; } = string.Empty;
        public string OperatingSystem { get; set; } = string.Empty;
        public string OsVersion { get; set; } = string.Empty;
        public bool IsVirtual { get; set; }
        public string VirtualizationPlatform { get; set; } = string.Empty; // VMware, Hyper-V, etc.
        public string ServerRole { get; set; } = string.Empty; // Domain Controller, File Server, etc.
        public List<string> InstalledApplications { get; set; } = new List<string>();
        public List<string> RunningServices { get; set; } = new List<string>();
        public string HardwareSpecifications { get; set; } = string.Empty;
        public string StorageConfiguration { get; set; } = string.Empty;
        public bool IsMonitored { get; set; }
        public bool IsBackedUp { get; set; }
        public List<string> SecurityIssues { get; set; } = new List<string>();
        public string Notes { get; set; } = string.Empty;
    }
}

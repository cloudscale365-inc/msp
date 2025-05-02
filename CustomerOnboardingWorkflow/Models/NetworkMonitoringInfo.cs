using System;
using System.Collections.Generic;

namespace CustomerOnboardingWorkflow.Models
{
    /// <summary>
    /// Contains network monitoring specific information for customer onboarding
    /// </summary>
    public class NetworkMonitoringInfo
    {
        public bool AccessGranted { get; set; }
        public string AccessMethod { get; set; } = string.Empty; // VPN, Site-to-Site, Direct, etc.
        public string VpnCredentials { get; set; } = string.Empty; // Note: In a real app, use secure storage
        public bool DiscoveryCompleted { get; set; }
        public DateTime? DiscoveryDate { get; set; }
        
        // Network infrastructure details
        public List<NetworkDevice> NetworkDevices { get; set; } = new List<NetworkDevice>();
        public int TotalDevicesDiscovered { get; set; }
        
        // Vulnerability assessment
        public bool VulnerabilityScanCompleted { get; set; }
        public int CriticalVulnerabilities { get; set; }
        public int HighVulnerabilities { get; set; }
        public int MediumVulnerabilities { get; set; }
        public int LowVulnerabilities { get; set; }
        public bool VulnerabilitiesReported { get; set; }
        public DateTime? VulnerabilityReportDate { get; set; }
        
        // Monitoring setup
        public bool MonitoringToolsInstalled { get; set; }
        public string MonitoringToolsNotes { get; set; } = string.Empty;
        public List<string> MonitoredServices { get; set; } = new List<string>();
        public bool AlertingConfigured { get; set; }
        public List<string> AlertRecipients { get; set; } = new List<string>();
        
        // Documentation
        public bool NetworkDocumented { get; set; }
        public string DocumentationLocation { get; set; } = string.Empty;
        public string AdditionalNotes { get; set; } = string.Empty;
    }
    
    /// <summary>
    /// Represents a network device discovered during onboarding
    /// </summary>
    public class NetworkDevice
    {
        public string Name { get; set; } = string.Empty;
        public string IpAddress { get; set; } = string.Empty;
        public string MacAddress { get; set; } = string.Empty;
        public string DeviceType { get; set; } = string.Empty; // Router, Switch, Firewall, etc.
        public string Manufacturer { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string FirmwareVersion { get; set; } = string.Empty;
        public bool IsMonitored { get; set; }
        public List<string> OpenPorts { get; set; } = new List<string>();
        public List<string> RunningServices { get; set; } = new List<string>();
        public List<string> Vulnerabilities { get; set; } = new List<string>();
    }
}

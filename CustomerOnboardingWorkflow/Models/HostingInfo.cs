using System;
using System.Collections.Generic;

namespace CustomerOnboardingWorkflow.Models
{
    /// <summary>
    /// Contains hosting specific information for customer onboarding
    /// </summary>
    public class HostingInfo
    {
        // Hosting requirements
        public string HostingType { get; set; } = string.Empty; // Shared, VPS, Dedicated, Cloud
        public string Provider { get; set; } = string.Empty;
        public bool IsNewHosting { get; set; } // New hosting or migration from existing
        public string MigrationSource { get; set; } = string.Empty;
        
        // Website information
        public List<WebsiteInfo> Websites { get; set; } = new List<WebsiteInfo>();
        public int TotalWebsites { get; set; }
        
        // Database information
        public List<DatabaseInfo> Databases { get; set; } = new List<DatabaseInfo>();
        public int TotalDatabases { get; set; }
        
        // Email hosting
        public bool IncludesEmailHosting { get; set; }
        public int NumberOfMailboxes { get; set; }
        public string EmailPlatform { get; set; } = string.Empty;
        
        // DNS information
        public string DomainRegistrar { get; set; } = string.Empty;
        public string DnsProvider { get; set; } = string.Empty;
        public bool DnsConfigured { get; set; }
        
        // SSL certificates
        public bool SslRequired { get; set; }
        public string SslProvider { get; set; } = string.Empty;
        public DateTime? SslExpirationDate { get; set; }
        
        // Backup configuration
        public bool BackupConfigured { get; set; }
        public string BackupFrequency { get; set; } = string.Empty;
        public string BackupRetention { get; set; } = string.Empty;
        
        // Monitoring
        public bool MonitoringConfigured { get; set; }
        public List<string> MonitoredMetrics { get; set; } = new List<string>();
        
        // Security
        public bool FirewallConfigured { get; set; }
        public bool WafConfigured { get; set; } // Web Application Firewall
        public bool DdosProtectionEnabled { get; set; }
        
        // Documentation
        public bool HostingDocumented { get; set; }
        public string DocumentationLocation { get; set; } = string.Empty;
        public string AdditionalNotes { get; set; } = string.Empty;
    }
    
    /// <summary>
    /// Represents a website in the hosting environment
    /// </summary>
    public class WebsiteInfo
    {
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string Technology { get; set; } = string.Empty; // WordPress, Custom PHP, ASP.NET, etc.
        public string ServerPath { get; set; } = string.Empty;
        public bool HasSsl { get; set; }
        public bool IsLive { get; set; }
        public DateTime? LaunchDate { get; set; }
        public string AdminUrl { get; set; } = string.Empty;
        public string AdminUsername { get; set; } = string.Empty;
        public string AdminPassword { get; set; } = string.Empty; // Note: In a real app, use secure storage
        public List<string> RelatedDatabases { get; set; } = new List<string>();
        public string Notes { get; set; } = string.Empty;
    }
    
    /// <summary>
    /// Represents a database in the hosting environment
    /// </summary>
    public class DatabaseInfo
    {
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty; // MySQL, SQL Server, PostgreSQL, etc.
        public string Server { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty; // Note: In a real app, use secure storage
        public string ConnectionString { get; set; } = string.Empty;
        public double SizeInMb { get; set; }
        public bool IsBackedUp { get; set; }
        public string Notes { get; set; } = string.Empty;
    }
}

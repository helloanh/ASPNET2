using System;
namespace EFGetStarted.AspNetCore.ExistingDb.Models
{
    public class MigrationFramework
    {
        public MigrationFramework()
        {
        }

        public int MigrationFrameworkId { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Definition { get; set; }
        public string ServiceType { get; set; }

    }
}

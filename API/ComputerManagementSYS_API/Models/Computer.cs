using System.ComponentModel.DataAnnotations.Schema;

namespace ComputerManagementSYS_API.Models
{
    public class Computer
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("computer_name")]
        public string ComputerName { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("processor")]
        public string Processor { get; set; }

        [Column("ram")]
        public string RAM { get; set; }

        [Column("storage")]
        public string Storage { get; set; }

        [Column("graphics_card")]
        public string? GraphicsCard { get; set; }

        [Column("operating_system")]
        public string OperatingSystem { get; set; }

        [Column("last_updated")]
        public DateTime LastUpdated { get; set; }
    }
}

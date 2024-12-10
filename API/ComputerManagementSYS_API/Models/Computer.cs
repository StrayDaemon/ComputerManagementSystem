namespace ComputerManagementSYS_API.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Processor { get; set; }
        public int RAM { get; set; } // in GB
        public int Storage { get; set; } // in GB
    }

}

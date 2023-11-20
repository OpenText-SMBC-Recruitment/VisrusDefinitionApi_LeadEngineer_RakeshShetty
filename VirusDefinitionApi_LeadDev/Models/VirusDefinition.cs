using System;

namespace VirusDefinitionApi_LeadDev.Models
{
    public class VirusDefinition
    {
        public Guid VirusIdentifier { get; set; }
        public string VirusName { get; set; }
        public string VirusSignature { get; set; }

        public int NumberOfInfectedDevices { get; set; }
}
}

using System;
using VirusDefinitionApi_LeadDev.Models;

namespace VirusDefinitionApi_LeadDev.Interfaces
{
    public interface IVirusDefinitionRepository
    {
        void InsertVirusDefinition(VirusDefinition virusDefinition);

        void UpdateVirusDefinition(VirusDefinition virusDefinition);

        VirusDefinition RetrieveVirusDefinitionByIdentifier(Guid virusDefinitionIdentifier);

        void RemoveVirusDefinition(Guid virusDefinitionIdentifier);
    }
}

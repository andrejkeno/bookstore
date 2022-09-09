using Rhetos.Dsl;
using Rhetos.Dsl.DefaultConcepts;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.RhetosExtensions
{
    [Export(typeof(IConceptMacro))]
    public class MonitoredRecordMacro : IConceptMacro<MonitoredRecordInfo>
    {
        public IEnumerable<IConceptInfo> CreateNewConcepts(MonitoredRecordInfo conceptInfo, IDslModel existingConcepts)
        {
            var concepts = new List<IConceptInfo>();

            var createdAt = new DateTimePropertyInfo()
            {
                DataStructure = conceptInfo.Entity,
                Name = "CreatedAt"
            };

            concepts.Add(new CreationTimeInfo() { Property = createdAt });
            concepts.Add(new DenyUserEditPropertyInfo() { Property = createdAt });

            var updatedAt = new DateTimePropertyInfo()
            {
                DataStructure = conceptInfo.Entity,
                Name = "UpdatedAt"
            };

            concepts.Add(new LastModifiedTimeInfo() { Property = updatedAt });
            concepts.Add(new DenyUserEditPropertyInfo() { Property = updatedAt });

            concepts.Add(new AllPropertiesLoggingInfo() { 
                EntityLogging = new EntityLoggingInfo() { Entity = conceptInfo.Entity } 
            });

            return concepts;
        }
    }
}

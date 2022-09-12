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

            concepts.Add(createdAt);

            concepts.Add(new CreationTimeInfo() { Property = createdAt });
            concepts.Add(new DenyUserEditPropertyInfo() { Property = createdAt });

            var updatedAt = new DateTimePropertyInfo()
            {
                DataStructure = conceptInfo.Entity,
                Name = "UpdatedAt"
            };

            concepts.Add(updatedAt);

            concepts.Add(new LastModifiedTimeInfo() { Property = updatedAt });
            concepts.Add(new DenyUserEditPropertyInfo() { Property = updatedAt });

            EntityLoggingInfo entityLoggingInfo = new EntityLoggingInfo() { Entity = conceptInfo.Entity };

            concepts.Add(entityLoggingInfo);
            concepts.Add(new AllPropertiesLoggingInfo() { 
                EntityLogging = entityLoggingInfo
            });

            return concepts;
        }
    }
}

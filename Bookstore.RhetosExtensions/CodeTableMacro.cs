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
    public class CodeTableMacro : IConceptMacro<CodeTableInfo>
    {
        public IEnumerable<IConceptInfo> CreateNewConcepts(CodeTableInfo conceptInfo, IDslModel existingConcepts)
        {
            var newConcepts = new List<IConceptInfo>();

            var code = new ShortStringPropertyInfo()
            {
                DataStructure = conceptInfo,
                Name = "Code"
            };

            newConcepts.Add(new AutoCodePropertyInfo()
            {
                Property = code
            });

            var name = new ShortStringPropertyInfo()
            {
                DataStructure = conceptInfo,
                Name = "Name"
            };

            newConcepts.Add(new RequiredPropertyInfo()
            {
                Property = name
            });

            return newConcepts;
        }
    }
}

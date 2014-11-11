using System.Collections.Generic;
using System.Runtime.Serialization;

using NuClear.Model.Common.Operations.Identity.Generic;

namespace NuClear.Metamodeling.Operations.Detail.Concrete
{
    [DataContract]
    public sealed class ActionHistoryMetadata : IOperationMetadata<ActionHistoryIdentity>
    {
        [DataMember]
        public IEnumerable<string> Properties { get; set; }
    }
}
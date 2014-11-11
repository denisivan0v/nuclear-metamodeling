using System.Runtime.Serialization;

using NuClear.Model.Common.Operations.Identity.Generic;

namespace NuClear.Metamodeling.Operations.Detail.Concrete
{
    [DataContract]
    public sealed class AssignMetadata : IOperationMetadata<AssignIdentity>
    {
        [DataMember]
        public bool PartialAssignSupported { get; set; }
        public bool IsCascadeAssignForbidden { get; set; }
    }
}
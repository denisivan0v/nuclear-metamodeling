using System.Runtime.Serialization;

using NuClear.Model.Common.Operations.Identity.Generic;

namespace NuClear.Metamodeling.Operations.Detail.Concrete
{
    [DataContract]
    public sealed class QualifyMetadata : IOperationMetadata<QualifyIdentity>
    {
        [DataMember]
        public bool CheckForDebtsSupported { get; set; }
    }
}
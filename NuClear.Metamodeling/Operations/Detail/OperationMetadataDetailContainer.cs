using System.Runtime.Serialization;

using NuClear.Model.Common.Entities;
using NuClear.Model.Common.Operations.Identity;

namespace NuClear.Metamodeling.Operations.Detail
{
    [DataContract]
    public sealed class OperationMetadataDetailContainer
    {
        public static class Empty
        {
            public static OperationMetadataDetailContainer NonCoupled 
            {
                get
                {
                    return new OperationMetadataDetailContainer { SpecificTypes = EntitySet.Create.NonCoupled };
                }
            }
            public static OperationMetadataDetailContainer GetNonCoupled<TOperationIdentity>()
                where TOperationIdentity : class, IOperationIdentity, new()
            {
                return new OperationMetadataDetailContainer
                           {
                               MetadataDetail = new EmptyOperationMetadata<TOperationIdentity>(), 
                               SpecificTypes = EntitySet.Create.NonCoupled
                           };
            }
        }

        [DataMember]
        public IOperationMetadata MetadataDetail { get; set; }
        [DataMember]
        public EntitySet SpecificTypes { get; set; }
    }
}

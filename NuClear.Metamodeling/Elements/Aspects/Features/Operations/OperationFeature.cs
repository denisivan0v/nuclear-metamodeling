using NuClear.Model.Common.Operations.Identity;

namespace NuClear.Metamodeling.Elements.Aspects.Features.Operations
{
    public sealed class OperationFeature : IMetadataFeature
    {
        public OperationFeature(StrictOperationIdentity strictOperationIdentity)
        {
            Identity = strictOperationIdentity;
        }

        public StrictOperationIdentity Identity { get; private set; }
    }
}
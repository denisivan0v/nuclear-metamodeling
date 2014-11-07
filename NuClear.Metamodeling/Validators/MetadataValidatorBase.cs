using NuClear.Metamodeling.Kinds;
using NuClear.Metamodeling.Provider;

namespace NuClear.Metamodeling.Validators
{
    public abstract class MetadataValidatorBase<TMetadataKindIdentity> : IMetadataValidator<TMetadataKindIdentity> 
        where TMetadataKindIdentity : class, IMetadataKindIdentity, new()
    {
        protected readonly IMetadataProvider MetadataProvider;
        protected readonly TMetadataKindIdentity TargetMetadataKind = new TMetadataKindIdentity();

        protected MetadataValidatorBase(IMetadataProvider metadataProvider)
        {
            MetadataProvider = metadataProvider;
        }

        public bool IsValid(out string report)
        {
            MetadataSet targetMetadataSet;
            if (!MetadataProvider.TryGetMetadata<TMetadataKindIdentity>(out targetMetadataSet))
            {
                report = "Can't get metadata set for target metadata kind " + typeof(TMetadataKindIdentity).Name;
                return false;
            }

            return IsValidImpl(targetMetadataSet, out report);
        }

        protected abstract bool IsValidImpl(MetadataSet targetMetadata, out string report);
    }
}
using NuClear.Metamodeling.Elements;
using NuClear.Metamodeling.Kinds;
using NuClear.Metamodeling.Provider;

namespace NuClear.Metamodeling.Processors
{
    public abstract class MetadataProcessorBase<TMetadataKindIdentity, TMetadataElement> : IMetadataProcessor 
        where TMetadataKindIdentity : class, IMetadataKindIdentity, new()
        where TMetadataElement : class, IMetadataElement
    {
        private readonly TMetadataKindIdentity _metadataKindIdentity = new TMetadataKindIdentity();

        public IMetadataKindIdentity[] TargetMetadataConstraints
        {
            get { return new IMetadataKindIdentity[] { _metadataKindIdentity }; }
        }

        public void Process(
            IMetadataKindIdentity metadataKind, 
            MetadataSet flattenedMetadata, 
            MetadataSet concreteKindMetadata, 
            IMetadataElement element)
        {
            var typedElement = element as TMetadataElement;
            if (typedElement == null)
            {
                return;
            }

            Process(metadataKind, flattenedMetadata, concreteKindMetadata, typedElement);
        }

        protected abstract void Process(
            IMetadataKindIdentity metadataKind, 
            MetadataSet flattenedMetadata, 
            MetadataSet concreteKindMetadata,
            TMetadataElement metadata);
    }
}
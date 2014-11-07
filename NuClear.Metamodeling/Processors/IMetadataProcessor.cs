using NuClear.Metamodeling.Elements;
using NuClear.Metamodeling.Kinds;
using NuClear.Metamodeling.Provider;

namespace NuClear.Metamodeling.Processors
{
    public interface IMetadataProcessor
    {
        IMetadataKindIdentity[] TargetMetadataConstraints { get; }
        void Process(
            IMetadataKindIdentity metadataKind, 
            MetadataSet flattenedMetadata, 
            MetadataSet concreteKindMetadata, 
            IMetadataElement element);
    }
}

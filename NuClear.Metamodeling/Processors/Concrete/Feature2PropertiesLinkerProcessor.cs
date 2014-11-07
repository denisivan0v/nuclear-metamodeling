using System.Linq;

using NuClear.Metamodeling.Entities;
using NuClear.Metamodeling.Kinds;
using NuClear.Metamodeling.Provider;

namespace NuClear.Metamodeling.Processors.Concrete
{
    public sealed class Feature2PropertiesLinkerProcessor : MetadataProcessorBase<MetadataEntitiesIdentity, EntityPropertyMetadata>
    {
        protected override void Process(
            IMetadataKindIdentity metadataKind,
            MetadataSet flattenedMetadata,
            MetadataSet concreteKindMetadata,
            EntityPropertyMetadata metadata)
        {
            foreach (var propertyFeature in metadata.Features.OfType<IPropertyFeature>())
            {
                propertyFeature.TargetPropertyMetadata = metadata;
            }
        }
    }
}
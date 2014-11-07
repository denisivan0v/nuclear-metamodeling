using NuClear.Metamodeling.Elements.Aspects.Features;

namespace NuClear.Metamodeling.Entities
{
    public interface IPropertyFeature : IMetadataFeature
    {
        EntityPropertyMetadata TargetPropertyMetadata { get; set; }
    }
}

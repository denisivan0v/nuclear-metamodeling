using System;

using NuClear.Metamodeling.Elements;
using NuClear.Metamodeling.Kinds;

namespace NuClear.Metamodeling.Provider
{
    public interface IMetadataProvider
    {
        MetadataSet Metadata { get; }
        bool TryGetMetadata(Uri uri, out IMetadataElement element);
        bool TryGetMetadata<TMetadataElement>(Uri uri, out TMetadataElement element)
            where TMetadataElement : class, IMetadataElement;
        bool TryGetMetadata<TMetadataKindIdentity>(out MetadataSet metadata) 
            where TMetadataKindIdentity : class, IMetadataKindIdentity, new();
    }
}

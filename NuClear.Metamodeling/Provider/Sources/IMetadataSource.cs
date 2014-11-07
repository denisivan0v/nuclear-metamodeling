using System;
using System.Collections.Generic;

using NuClear.Metamodeling.Elements;
using NuClear.Metamodeling.Kinds;

namespace NuClear.Metamodeling.Provider.Sources
{
    public interface IMetadataSource
    {
        IMetadataKindIdentity Kind { get; }
        IReadOnlyDictionary<Uri, IMetadataElement> Metadata { get; }
    }

    public interface IMetadataSource<TMetadataKindIdentity> : IMetadataSource
        where TMetadataKindIdentity : class, IMetadataKindIdentity, new()
    {
    }
}

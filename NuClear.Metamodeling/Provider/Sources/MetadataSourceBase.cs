using System;
using System.Collections.Generic;

using NuClear.Metamodeling.Elements;
using NuClear.Metamodeling.Kinds;

namespace NuClear.Metamodeling.Provider.Sources
{
    public abstract class MetadataSourceBase<TMetadataKindIdentity> : IMetadataSource<TMetadataKindIdentity> 
        where TMetadataKindIdentity : class, IMetadataKindIdentity, new()
    {
        private readonly IMetadataKindIdentity _metadataKindIdentity = new TMetadataKindIdentity();

        public IMetadataKindIdentity Kind
        {
            get { return _metadataKindIdentity; }
        }

        public abstract IReadOnlyDictionary<Uri, IMetadataElement> Metadata { get; }
    }
}
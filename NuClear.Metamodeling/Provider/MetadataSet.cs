using System;
using System.Collections.Generic;

using NuClear.Metamodeling.Elements;

namespace NuClear.Metamodeling.Provider
{
    public sealed class MetadataSet
    {
        private readonly Dictionary<Uri, IMetadataElement> _metadata;

        public MetadataSet(Dictionary<Uri, IMetadataElement> metadata)
        {
            _metadata = metadata;
        }

        public MetadataSet()
        {
            _metadata = new Dictionary<Uri, IMetadataElement>();
        }

        public Dictionary<Uri, IMetadataElement> Metadata
        {
            get { return _metadata; }
        }
    }
}
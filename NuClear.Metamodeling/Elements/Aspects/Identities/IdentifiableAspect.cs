using System;

namespace NuClear.Metamodeling.Elements.Aspects.Identities
{
    public sealed class IdentifiableAspect<TBuilder, TMetadataElement>
        where TBuilder : MetadataElementBuilder<TBuilder, TMetadataElement>, new()
        where TMetadataElement : MetadataElement<TMetadataElement, TBuilder>
    {
        private readonly TBuilder _aspectHostBuilder;

        public IdentifiableAspect(TBuilder aspectHostBuilder)
        {
            _aspectHostBuilder = aspectHostBuilder;
        }

        public bool HasValue { get; private set; }
        public Uri Value { get; private set; }

        public TBuilder Is(Uri id)
        {
            HasValue = true;
            Value = id;
            return _aspectHostBuilder;
        }
    }
}
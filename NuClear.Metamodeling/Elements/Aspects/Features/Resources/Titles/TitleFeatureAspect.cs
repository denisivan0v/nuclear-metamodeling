using System;
using System.Linq.Expressions;

namespace NuClear.Metamodeling.Elements.Aspects.Features.Resources.Titles
{
    public sealed class TitleFeatureAspect<TBuilder, TMetadataElement> : MetadataElementBuilderAspectBase<TBuilder, ITitledElement, TMetadataElement>
        where TBuilder : MetadataElementBuilder<TBuilder, TMetadataElement>, new()
        where TMetadataElement : MetadataElement, ITitledElement
    {
        public TitleFeatureAspect(MetadataElementBuilder<TBuilder, TMetadataElement> aspectHostBuilder)
            : base(aspectHostBuilder)
        {
        }

        public TBuilder Resource<TKey>(Expression<Func<TKey>> resourceKeyExpression)
        {
            AspectHostBuilder.WithFeatures(new TitleFeature(ResourceTitleDescriptor.Create(resourceKeyExpression)));
            return AspectHostBuilder;
        }

        public TBuilder Static(string title)
        {
            AspectHostBuilder.WithFeatures(new TitleFeature(new StaticTitleDescriptor(title)));
            return AspectHostBuilder;
        }
    }
}
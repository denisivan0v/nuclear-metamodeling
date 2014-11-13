using NuClear.Metamodeling.Elements.Aspects.Features.Handler.Concrete;
using NuClear.Metamodeling.Elements.Aspects.Features.Operations;
using NuClear.Model.Common.Entities;
using NuClear.Model.Common.Operations.Identity;
using NuClear.Model.Common.Operations.Identity.Generic;

namespace NuClear.Metamodeling.Elements.Aspects.Features.Handler
{
    public sealed class HandlerFeatureAspect<TBuilder, TMetadataElement> : MetadataElementBuilderAspectBase<TBuilder, IHandlerBoundElement, TMetadataElement>
        where TBuilder : MetadataElementBuilder<TBuilder, TMetadataElement>, new()
        where TMetadataElement : MetadataElement, IHandlerBoundElement
    {
        public HandlerFeatureAspect(MetadataElementBuilder<TBuilder, TMetadataElement> aspectHostBuilder)
            : base(aspectHostBuilder)
        {
        }

        public TBuilder Use(IHandlerFeature feature)
        {
            AspectHostBuilder.WithFeatures(feature);
            return AspectHostBuilder;
        }

        public TBuilder ShowGridByConvention(IEntityType entityName, string filterExpression, string disableExpression)
        {
            AspectHostBuilder.WithFeatures(new ShowGridHandlerFeature(entityName)
                {
                    FilterExpression = filterExpression, 
                    DisableExpression = disableExpression
                });

            return AspectHostBuilder.AddOperation<TBuilder, TMetadataElement>(ListIdentity.Instance.SpecificFor(entityName));
        }
    }
}

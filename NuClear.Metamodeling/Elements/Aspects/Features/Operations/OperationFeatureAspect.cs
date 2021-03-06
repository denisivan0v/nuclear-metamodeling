﻿using NuClear.Model.Common.Entities;
using NuClear.Model.Common.Entities.Aspects;
using NuClear.Model.Common.Operations.Identity;

namespace NuClear.Metamodeling.Elements.Aspects.Features.Operations
{
    public sealed class OperationFeatureAspect<TBuilder, TMetadataElement> : MetadataElementBuilderAspectBase<TBuilder, IOperationsBoundElement, TMetadataElement>
        where TBuilder : MetadataElementBuilder<TBuilder, TMetadataElement>, new()
        where TMetadataElement : MetadataElement, IOperationsBoundElement
    {
        public OperationFeatureAspect(MetadataElementBuilder<TBuilder, TMetadataElement> aspectHostBuilder)
            : base(aspectHostBuilder)
        {
        }

        public TBuilder SpecificFor<TOperationIdentity>(params IEntityType[] operationEntities)
            where TOperationIdentity : OperationIdentityBase<TOperationIdentity>, IEntitySpecificOperationIdentity, new()
        {
            return AspectHostBuilder.AddEntitySpecificOperation<TBuilder, TMetadataElement, TOperationIdentity>(operationEntities);
        }

        public TBuilder SpecificFor<TOperationIdentity, TEntity>()
            where TOperationIdentity : OperationIdentityBase<TOperationIdentity>, IEntitySpecificOperationIdentity, new()
            where TEntity : class, IEntity
        {
            return AspectHostBuilder.AddEntitySpecificOperation<TBuilder, TMetadataElement, TOperationIdentity, TEntity>();
        }

        public TBuilder SpecificFor<TOperationIdentity, TEntity1, TEntity2>()
            where TOperationIdentity : OperationIdentityBase<TOperationIdentity>, IEntitySpecificOperationIdentity, new()
            where TEntity1 : class, IEntity
            where TEntity2 : class, IEntity
        {
            return AspectHostBuilder.AddEntitySpecificOperation<TBuilder, TMetadataElement, TOperationIdentity, TEntity1, TEntity2>();
        }

        public TBuilder NonCoupled<TOperationIdentity>()
            where TOperationIdentity : OperationIdentityBase<TOperationIdentity>, INonCoupledOperationIdentity, new()
        {
            return AspectHostBuilder.AddNonCoupledOperation<TBuilder, TMetadataElement, TOperationIdentity>();
        }
    }
}
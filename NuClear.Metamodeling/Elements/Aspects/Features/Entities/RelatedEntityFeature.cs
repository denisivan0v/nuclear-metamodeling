using NuClear.Model.Common.Entities;

namespace NuClear.Metamodeling.Elements.Aspects.Features.Entities
{
    public sealed class RelatedEntityFeature : IUniqueMetadataFeature
    {
        private readonly IEntityType _entity;

        public RelatedEntityFeature(IEntityType entity)
        {
            _entity = entity;
        }

        public IEntityType Entity
        {
            get { return _entity; }
        }
    }
}

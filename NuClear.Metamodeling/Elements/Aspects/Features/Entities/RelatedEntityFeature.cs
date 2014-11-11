using NuClear.Model.Common.Entities;

namespace NuClear.Metamodeling.Elements.Aspects.Features.Entities
{
    public sealed class RelatedEntityFeature : IUniqueMetadataFeature
    {
        private readonly EntityType _entity;

        public RelatedEntityFeature(EntityType entity)
        {
            _entity = entity;
        }

        public EntityType Entity
        {
            get { return _entity; }
        }
    }
}

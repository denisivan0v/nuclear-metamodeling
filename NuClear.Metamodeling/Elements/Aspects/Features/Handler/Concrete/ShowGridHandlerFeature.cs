using NuClear.Model.Common.Entities;

namespace NuClear.Metamodeling.Elements.Aspects.Features.Handler.Concrete
{
    public sealed class ShowGridHandlerFeature : IHandlerFeature
    {
        private readonly EntityType _entityName;

        public ShowGridHandlerFeature(EntityType entityName)
        {
            _entityName = entityName;
        }

        public EntityType EntityName
        {
            get
            {
                return _entityName;
            }
        }

        public string FilterExpression { get; set; }
        public string DisableExpression { get; set; }
    }
}

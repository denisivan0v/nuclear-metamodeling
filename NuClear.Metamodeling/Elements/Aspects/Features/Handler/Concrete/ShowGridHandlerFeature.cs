using NuClear.Model.Common.Entities;

namespace NuClear.Metamodeling.Elements.Aspects.Features.Handler.Concrete
{
    public sealed class ShowGridHandlerFeature : IHandlerFeature
    {
        private readonly IEntityType _entityName;

        public ShowGridHandlerFeature(IEntityType entityName)
        {
            _entityName = entityName;
        }

        public IEntityType EntityName
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

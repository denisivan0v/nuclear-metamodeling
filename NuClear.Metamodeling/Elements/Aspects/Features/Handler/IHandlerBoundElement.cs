namespace NuClear.Metamodeling.Elements.Aspects.Features.Handler
{
    public interface IHandlerBoundElement : IMetadataElementAspect
    {
        IHandlerFeature Handler { get; }
        bool HasHandler { get; }
    }
}
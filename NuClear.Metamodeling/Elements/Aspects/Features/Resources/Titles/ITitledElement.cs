namespace NuClear.Metamodeling.Elements.Aspects.Features.Resources.Titles
{
    public interface ITitledElement : IMetadataElementAspect
    {
        ITitleDescriptor TitleDescriptor { get; }
    }
}

using System.Collections.Generic;

namespace NuClear.Metamodeling.Elements.Aspects.Features.Operations
{
    public interface IOperationsBoundElement : IMetadataElementAspect
    {
        bool HasOperations { get; }
        IEnumerable<OperationFeature> OperationFeatures { get; }
    }
}
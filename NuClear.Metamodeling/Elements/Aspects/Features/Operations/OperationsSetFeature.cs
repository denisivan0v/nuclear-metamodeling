using System.Collections.Generic;

namespace NuClear.Metamodeling.Elements.Aspects.Features.Operations
{
    public sealed class OperationsSetFeature : IMetadataFeature
    {
        private readonly List<OperationFeature> _operationFeatures = new List<OperationFeature>();

        public ICollection<OperationFeature> OperationFeatures
        {
            get
            {
                return _operationFeatures;
            }
        }
    }
}
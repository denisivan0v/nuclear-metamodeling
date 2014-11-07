using System.Collections.Generic;

using NuClear.Metamodeling.Elements.Aspects.Features;
using NuClear.Metamodeling.Elements.Identities;
using NuClear.Metamodeling.Kinds;

namespace NuClear.Metamodeling.Elements
{
    public interface IMetadataElementUpdater
    {
        void ActualizeId(IMetadataElementIdentity actualMetadataElementIdentity);
        void ActualizeKind(IMetadataKindIdentity actualMetadataKindIdentity);
        void SetParent(IMetadataElement parentElement);
        void ReferencedBy(IMetadataElement parentElement);
        void AddChilds(IEnumerable<IMetadataElement> childs);
        void ReplaceChilds(IEnumerable<IMetadataElement> childs);
        void AddFeature(IMetadataFeature feature);
    }
}
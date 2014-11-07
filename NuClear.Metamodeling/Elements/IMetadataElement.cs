using System.Collections.Generic;

using NuClear.Metamodeling.Elements.Aspects.Features;
using NuClear.Metamodeling.Elements.Identities;
using NuClear.Metamodeling.Kinds;

namespace NuClear.Metamodeling.Elements
{
    /// <summary>
    /// Базовый интерфейс элемента метаданных, таким элементом может быть,
    /// сущность ERM, элемент иерархии, карточка, документ и др.
    /// </summary>
    public interface IMetadataElement
    {
        IMetadataElementIdentity Identity { get; }
        IMetadataKindIdentity Kind { get; }
        IEnumerable<IMetadataFeature> Features { get; }

        IMetadataElement Parent { get; }
        IMetadataElement[] References { get; }
        int DeepLevel { get; }
        IMetadataElement[] Elements { get; }
    }
}

using System;
using System.Linq;

using NuClear.Metamodeling.Elements.Aspects.Conditions;
using NuClear.Metamodeling.Elements.Aspects.Features;
using NuClear.Metamodeling.Elements.Identities;

namespace NuClear.Metamodeling.Elements.Concrete.References
{
    public sealed class MetadataReference : MetadataElement<MetadataReference, MetadataReferenceBuilder>
    {
        private readonly Uri _referencedElementId;
        private IMetadataElementIdentity _identity;

        public MetadataReference(Uri referencedElementId)
            : base(Enumerable.Empty<IMetadataFeature>())
        {
            _identity = IdBuilder.StubUnique.AsIdentity();
            _referencedElementId = referencedElementId;
        }
        
        public override IMetadataElementIdentity Identity
        {
            get { return _identity; }
        }

        public Uri ReferencedElementId
        {
            get
            {
                return _referencedElementId;
            }
        }

        public ICondition Condition { get; set; }

        public override void ActualizeId(IMetadataElementIdentity actualMetadataElementIdentity)
        {
            _identity = actualMetadataElementIdentity;
        }
    }
}
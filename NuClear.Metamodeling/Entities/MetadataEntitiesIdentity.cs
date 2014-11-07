using System;

using NuClear.Metamodeling.Elements.Identities;
using NuClear.Metamodeling.Kinds;

namespace NuClear.Metamodeling.Entities
{
    public sealed class MetadataEntitiesIdentity : MetadataKindIdentityBase<MetadataEntitiesIdentity>
    {
        private readonly Uri _id = IdBuilder.For("Entities");

        public override Uri Id
        {
            get { return _id; }
        }

        public override string Description
        {
            get { return "Erm entity descriptive metadata"; }
        }
    }
}

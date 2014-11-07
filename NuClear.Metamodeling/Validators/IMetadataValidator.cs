using NuClear.Metamodeling.Kinds;

namespace NuClear.Metamodeling.Validators
{
    public interface IMetadataValidator
    {
        bool IsValid(out string report);
    }

    public interface IMetadataValidator<TMetadataKindIdentity> : IMetadataValidator
        where TMetadataKindIdentity : class, IMetadataKindIdentity, new()
    {
    }
}

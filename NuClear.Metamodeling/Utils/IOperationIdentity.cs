using System;
using System.Security.Principal;

namespace NuClear.Metamodeling.Utils
{
    public interface IOperationIdentity : IIdentity, IEquatable<IOperationIdentity>
    {
    }
}

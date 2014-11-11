using System;
using System.Reflection;
using System.Runtime.Serialization;

using NuClear.Model.Common.Operations.Identity;

namespace NuClear.Metamodeling.Operations.Detail
{
    [DataContract(Name = "EmptyOperationMetadata_Of_{0}")]
    public sealed class EmptyOperationMetadata<TOperationIdentity> : IOperationMetadata<TOperationIdentity>
        where TOperationIdentity : IOperationIdentity
    {
    }

    public static class EmptyOperationMetadata
    {
        public static class Create
        {
            public static IOperationMetadata ForIdentityType(Type identityType)
            {
                if (!typeof(IOperationIdentity).GetTypeInfo().IsAssignableFrom(identityType.GetTypeInfo()))
                {
                    throw new ArgumentException(identityType + " is not valid operation identity type");
                }

                return (IOperationMetadata)Activator.CreateInstance(typeof(EmptyOperationMetadata<>).MakeGenericType(identityType));
            }
        }
    }
}
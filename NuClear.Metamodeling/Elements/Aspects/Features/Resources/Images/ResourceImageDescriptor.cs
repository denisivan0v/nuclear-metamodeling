using System;
using System.Linq.Expressions;

using NuClear.Metamodeling.Utils;
using NuClear.Metamodeling.Utils.Resources;

namespace NuClear.Metamodeling.Elements.Aspects.Features.Resources.Images
{
    public sealed class ResourceImageDescriptor : IImageDescriptor
    {
        private readonly ResourceEntryKey _resourceEntryKey;

        public ResourceImageDescriptor(ResourceEntryKey resourceEntryKey)
        {
            _resourceEntryKey = resourceEntryKey;
        }

        public ResourceEntryKey ResourceEntryKey
        {
            get
            {
                return _resourceEntryKey;
            }
        }
        
        public static ResourceImageDescriptor Create<TKey>(Expression<Func<TKey>> resourceKeyExpression)
        {
            string keyName = StaticReflection.GetMemberName(resourceKeyExpression);
            Type resourceManagerType = StaticReflection.GetMemberDeclaringType(resourceKeyExpression);
            return new ResourceImageDescriptor(new ResourceEntryKey(resourceManagerType, keyName));
        }
    }
}
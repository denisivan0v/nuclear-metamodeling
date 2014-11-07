using System;
using System.Linq.Expressions;

using NuClear.Metamodeling.Utils;
using NuClear.Metamodeling.Utils.Resources;

namespace NuClear.Metamodeling.Elements.Aspects.Features.Resources.Titles
{
    public sealed class ResourceTitleDescriptor : ITitleDescriptor
    {
        private readonly ResourceEntryKey _resourceEntryKey;

        public ResourceTitleDescriptor(ResourceEntryKey resourceEntryKey)
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
        
        public static ResourceTitleDescriptor Create<TKey>(Expression<Func<TKey>> resourceKeyExpression)
        {
            string keyName = StaticReflection.GetMemberName(resourceKeyExpression);
            Type resourceManagerType = StaticReflection.GetMemberDeclaringType(resourceKeyExpression);
            return new ResourceTitleDescriptor(new ResourceEntryKey(resourceManagerType, keyName));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NuClear.Metamodeling.Prerequisites
{
    public sealed class ConsideringPrerequisitesComparer<TItem> : IComparer<TItem>
        where TItem : class
    {
        public int Compare(TItem one, TItem another)
        {
            if (one == null)
            {
                if (another == null)
                {
                    return 0;
                }

                return -1;
            }

            var oneType = one as Type ?? one.GetType();
            var anotherType = another as Type ?? another.GetType();

            var prerequsites = (PrerequisitesAttribute[])oneType.GetTypeInfo().GetCustomAttributes(typeof(PrerequisitesAttribute), false);
            return prerequsites.Any(t => t.Prerequisites.Contains(anotherType)) ? 1 : 0;
        }
    }
}
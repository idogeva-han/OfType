using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfType
{
    internal class TypeChecker : IOfType
    {
        public IEnumerable<T> GetOfType<T>(IEnumerable enumerable)
        {
            List<T> list = new List<T>();
            foreach (var item in enumerable)
            {
                if (item is T genericItem)
                {
                    list.Add(genericItem);
                }
            }

            return list;
        }

        public IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable)
        {
            List<TOutput> list = new List<TOutput>();
            foreach (var item in enumerable)
            {
                if (item is TOutput genericItem)
                {
                    list.Add(genericItem);
                }
            }

            return list;
        }

        public IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase
        {
            List<TBase> list = new List<TBase>();
            foreach (var item in derivedItems)
            {
                if (item is TBase genericItem)
                {
                    list.Add(genericItem);
                }
            }

            return list;
        }
    }
}

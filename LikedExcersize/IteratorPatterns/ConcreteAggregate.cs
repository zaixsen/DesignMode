
using System.Collections.Generic;

namespace LikedExcersize.IteratorPatterns
{
    /// <summary>
    /// 具体聚合对象
    /// </summary>
    public class ConcreteAggregate : Aggregate
    {
        private IList<object> items = new List<object>();

        public override Iterator CreateItertor()
        {
            return new ConcreteInterator(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}

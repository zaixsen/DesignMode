namespace LikedExcersize.IteratorPatterns
{
    public class ConcreteInterator : Iterator
    {
        //具体聚合类
        private ConcreteAggregate aggregate;

        private int current = 0;

        public ConcreteInterator(ConcreteAggregate concreteAggregate)
        {
            this.aggregate = concreteAggregate;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count ? true : false;
        }

        public override object Next()
        {
            object ret = null;
            current++;
            if (current < aggregate.Count)
            {
                ret = aggregate[current];
            }
            return ret;
        }
    }
}
